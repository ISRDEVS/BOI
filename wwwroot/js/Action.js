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

function DeleteData() {

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

function ClrscrFrom() {
    ClearInputValue("input[type=text], input[type=checkbox], select, input[type=radio],input[type=password]");
}


