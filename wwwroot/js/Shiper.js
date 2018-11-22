$(document).ready(function(){
    //alert('Shiper.js');
    var table = document.getElementById('tbshiperlist');
                
    for(var i = 1; i < table.rows.length; i++)
    {
        table.rows[i].onclick = function()
        {
            document.getElementById("UpdateOriginCountry").value=this.cells[2].innerHTML;
            document.getElementById("UpdateShipper").value=this.cells[3].innerHTML;
            document.getElementById("UpdateShotName").value=this.cells[4].innerHTML;
            document.getElementById("UpdateAddress").value=this.cells[5].innerHTML;
            document.getElementById("UpdateCountryCode").value=this.cells[6].innerHTML;
            document.getElementById("UpdateZipcode").value=this.cells[7].innerHTML;
            document.getElementById("UpdateAirport").value=this.cells[8].innerHTML;
            document.getElementById("UpdateIncoterm").value=this.cells[9].innerHTML;
            document.getElementById("UpdateShipmentPrivilege").value=this.cells[10].innerHTML;
            document.getElementById("UpdateDescription").value=this.cells[11].innerHTML;
            document.getElementById("iddelete").value=this.cells[0].innerHTML;
         
        };
    }
});


