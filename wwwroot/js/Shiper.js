
$("#btnsaveshiper").click(function (e) {
    return;
        e.preventDefault();
    alert('AjaxOK');
                $.ajax({
        type: "POST",
    url: "/MasterData/SaveShiper",
    data: $("#fromaddshiper").serialize(),
    contentType: "application/json; charset=utf-8",
    dataType: "json",
                    success: function (response) {
        alert("Hello: " + response.d);
    },
                    failure: function (response) {
        alert(response.responseText);
    },
                    error: function (response) {
        alert(response.responseText);
    }
});
});

