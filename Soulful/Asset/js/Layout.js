function Send()
{
    let nameElement = document.querySelector('#name');
    let emailElement = document.querySelector('#email');
    let subjectElement = document.querySelector('#subject');
    let messageElement = document.querySelector('#message');
    let input = document.querySelector('#giveback').querySelectorAll('input');

    let name = nameElement.value;
    let email = emailElement.value;
    let subject = subjectElement.value;
    let message = messageElement.value;

    let dataisnull = false;

        $.ajax({
            type: "POST",
            url: "/GiveBack/CreateData",
            data: { Name: name, Email: email, Subject: subject, Message: message },
            dataType: "text",
            success: function (response) {
                alert("感謝回饋");
            }
        });  
}