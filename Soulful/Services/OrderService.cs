﻿using ECPay.Payment.Integration;
using Soulful.Controllers;
using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebGrease.Css.Extensions;

namespace Soulful.Services
{
    public class OrderService
    {
        private SoulfulContext _context;
        SoulfulRepository<Order> _orderRepo;
        SoulfulRepository<OrderDetail> _odRepo;
        public OrderService()
        {
            _context = new SoulfulContext();
            _orderRepo = new SoulfulRepository<Order>(_context);
            _odRepo = new SoulfulRepository<OrderDetail>(_context);
        }

        public void Create(OrderViewModel orderView, string userId, List<CartViewModel> cartItems)
        {
            Order order = new Order()
            {
                RecieverName = orderView.RecieverName,
                RecieverPhone = orderView.RecieverPhone,
                RecieverAdress = orderView.RecieverAdress,
                Datetime = DateTime.Now,
                AspNetUsers_Id = userId
            };


            _orderRepo.Create(order);

            _context.SaveChanges();


            cartItems.ForEach(item =>
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Order_id = order.Order_id,
                    Album_id = item.Id,
                    Count = item.Count,
                    Price = item.Price
                };

                _odRepo.Create(orderDetail);

                _context.SaveChanges();
            });
        }

        public IEnumerable<Order> GetUserOrders(string userId)
        {
            var result = _orderRepo.GetAll().Where(x => x.AspNetUsers_Id.Equals(userId));

            return result;
        }
        public EcPayViewModel GetEcPayOrderDetail()
        {
            List<string> enErrors = new List<string>();
            EcPayViewModel Feedback = new EcPayViewModel();
            Hashtable htFeedback = null;
            try
            {
                using (AllInOne oPayment = new AllInOne())
                {
                    oPayment.HashKey = "5294y06JbISpM5x9";//ECPay 提供的 HashKey
                    oPayment.HashIV = "v77hoKGq4kWxNNIS";//ECPay 提供的 HashIV
                    /* 取回付款結果 */
                    enErrors.AddRange(oPayment.CheckOutFeedback(ref htFeedback));
                }
                // 取回所有資料
                if (enErrors.Count() == 0)
                {
                    /* 支付後的回傳的基本參數 */
                    string szMerchantID = String.Empty;
                    string szMerchantTradeNo = String.Empty;
                    string szPaymentDate = String.Empty;
                    string szPaymentType = String.Empty;
                    string szPaymentTypeChargeFee = String.Empty;
                    string szRtnCode = String.Empty;
                    string szRtnMsg = String.Empty;
                    string szSimulatePaid = String.Empty;
                    string szTradeAmt = String.Empty;
                    string szTradeDate = String.Empty;
                    string szTradeNo = String.Empty;
                    string szCustomField1 = String.Empty;
                    string szCustomField2 = String.Empty;
                    string szCustomField3 = String.Empty;
                    string szCustomField4 = String.Empty;
                    // 取得資料
                    foreach (string szKey in htFeedback.Keys)
                    {
                        switch (szKey)
                        {
                            /* 支付後的回傳的基本參數 */
                            case "MerchantID": szMerchantID = htFeedback[szKey].ToString(); break;
                            case "MerchantTradeNo": szMerchantTradeNo = htFeedback[szKey].ToString(); break;
                            case "PaymentDate": szPaymentDate = htFeedback[szKey].ToString(); break;
                            case "PaymentType": szPaymentType = htFeedback[szKey].ToString(); break;
                            case "PaymentTypeChargeFee": szPaymentTypeChargeFee = htFeedback[szKey].ToString(); break;
                            case "RtnCode": szRtnCode = htFeedback[szKey].ToString(); break;
                            case "RtnMsg": szRtnMsg = htFeedback[szKey].ToString(); break;
                            case "SimulatePaid": szSimulatePaid = htFeedback[szKey].ToString(); break;
                            case "TradeAmt": szTradeAmt = htFeedback[szKey].ToString(); break;
                            case "TradeDate": szTradeDate = htFeedback[szKey].ToString(); break;
                            case "TradeNo": szTradeNo = htFeedback[szKey].ToString(); break;
                            case "CustomField1": szCustomField1 = htFeedback[szKey].ToString(); break;
                            case "CustomField2": szCustomField2 = htFeedback[szKey].ToString(); break;
                            case "CustomField3": szCustomField3 = htFeedback[szKey].ToString(); break;
                            case "CustomField4": szCustomField4 = htFeedback[szKey].ToString(); break;
                            default: break;
                        }
                    }


                    Feedback.MerchantID = szMerchantID;
                    Feedback.MerchantTradeNo = szMerchantTradeNo;
                    Feedback.PaymentDate = szPaymentDate;
                    Feedback.PaymentType = szPaymentType;
                    Feedback.PaymentTypeChargeFee = szPaymentTypeChargeFee;
                    Feedback.RtnCode = szRtnCode;
                    Feedback.RtnMsg = szRtnMsg;
                    Feedback.SimulatePaid = szSimulatePaid;
                    Feedback.TradeAmt = szTradeAmt;
                    Feedback.TradeDate = szTradeDate;
                    Feedback.TradeNo = szTradeNo;
                    Feedback.CustomField1 = szCustomField1;
                    Feedback.CustomField2 = szCustomField2;
                    Feedback.CustomField3 = szCustomField3;
                    Feedback.CustomField4 = szCustomField4;


                }
                else
                {
                    // 其他資料處理。
                }
            }
            catch (Exception ex)
            {
                // 例外錯誤處理。
                enErrors.Add(ex.Message);
            }

            return Feedback;

        }
        public Order GetOrderById(int? id)
        {
            var result = _orderRepo.GetAll().FirstOrDefault(x => x.Order_id == id);

            return result;
        }
        public List<OrderDetailViewModel> GetUserOrdersByEmail(string email)
        {
            var orderTemp = _orderRepo.GetAll().Where(x => x.AspNetUsers.Email == email).Distinct();

            var result = new List<OrderDetailViewModel>();

            orderTemp.ForEach(item =>
            {
                result.Add(new OrderDetailViewModel()
                {
                    OrderId = item.Order_id,
                    OrderDetails = _odRepo.GetAll().Where(x => x.Order_id == item.Order_id).Select(x => new ApiOrderDetail
                    {
                        Count = x.Count,
                        Product = x.Album.Album_Name,
                        UnitPrice = x.Price

                    }).ToList()
                });
            });

            return result.ToList();

        }

    }
}


