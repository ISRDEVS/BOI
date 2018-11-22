var iddelete='';
var allcontrolname='';
var alldeactionname='';
var allclassname='';
var allelname='';
function SaveData(elname,controlname,actionname) {
    //alert('Action');
    //return;
    $.post("/"+controlname+"/"+actionname, $("#" + elname).serialize(),
        function (data) {
            if (data == 'OK') {
                Message('สำเร็จ', 'บันทึกข้อมูลเสร็จสิ้น');
            
            } else {
                MessageFail('พบข้อผิดพลาด :', data);
            }
        });
}

function UpdateData() {
    $.post("/" + controlname + "/" + actionname, $("#" + elname).serialize(),
        function (data) {
            if (data == 'OK') {
                Message('สำเร็จ', 'บันทึกข้อมูลเสร็จสิ้น');

            } else {
                MessageFail('พบข้อผิดพลาด :', data);
            }
        });
}

function MessageDeleteData(controlname,actionname,classname,elname) {
    allclassname=classname;
    allelname=elname;
    //iddelete= document.getElementById(elname).value;
    allcontrolname=controlname;
    alldeactionname=actionname;
MessageConfirm(elname,'ต้องการลบข้อมูล ใช่ หรือ ไม่');
}

function DeleteData() {   
  var id = document.getElementById("iddelete").value;
   $.post("/" + allcontrolname + "/" + alldeactionname,{id:id},
    function (data) {
        if (data == 'OK') {
            Message('สำเร็จ', 'ลบข้อมูลเสร็จสิ้น');

        } else {
            MessageFail('พบข้อผิดพลาด :', data);
        }
    });
}

function Message(title, body) {
    $("#titlemodalmess").html(title);
    $("#bodymess").html(body);
    $("#modal-success").modal('show');
}

function MessageFail(title, body) {
    $("#titlefail").html(title);
    $("#bodyfail").html(body);
    $("#modal-danger").modal('show');
}

function  MessageConfirm(title, body)  {
    $("#titlemodaldelete").html(title);
    $("#bodydelete").html(body);
    $("#modal-delete").modal('show');
}

function ClrscrFrom() {
    ClearInputValue("input[type=text], input[type=checkbox], select, input[type=radio],input[type=password]");
}

function ReloadData(){
    location.reload();
}
$('.delete_sp a').click(function(event) {
    event.preventDefault();
});


/*$('.delete_sp a').click(function (event) {
    if(MessageConfirm)
    $.get($(this).attr('href'), function (data) {
        if()
    });
});*/


$(document).ready(function(){
//alert('TastTable');
    //alert('Shiper.js');
    var table = document.getElementById('tblist');
                
    for(var i = 1; i < table.rows.length; i++)
    {
        table.rows[i].onclick = function()
        {
            alert(this.cells[0].innerHTML+'/'+this.cells[1].innerHTML);
           /* document.getElementById("UpdateOriginCountry").value=this.cells[2].innerHTML;
            document.getElementById("UpdateShipper").value=this.cells[3].innerHTML;
            document.getElementById("UpdateShotName").value=this.cells[4].innerHTML;
            document.getElementById("UpdateAddress").value=this.cells[5].innerHTML;
            document.getElementById("UpdateCountryCode").value=this.cells[6].innerHTML;
            document.getElementById("UpdateZipcode").value=this.cells[7].innerHTML;
            document.getElementById("UpdateAirport").value=this.cells[8].innerHTML;
            document.getElementById("UpdateIncoterm").value=this.cells[9].innerHTML;
            document.getElementById("UpdateShipmentPrivilege").value=this.cells[10].innerHTML;
            document.getElementById("UpdateDescription").value=this.cells[11].innerHTML;
            document.getElementById("iddelete").value=this.cells[0].innerHTML; */
         
        };
    }
});


