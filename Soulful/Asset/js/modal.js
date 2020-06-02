
for(let i=0;i<12;i++){
    let img=document.querySelectorAll('.single-album')[i];
    
    img.addEventListener('click' ,()=>{
        $('#modalQuickView').modal('show');
       
     })
     
}

