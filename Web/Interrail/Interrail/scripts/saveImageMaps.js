var markers = new Array();
               

window.onload = function () {
   var u= document.getElementById('<%=Label1.ClientID%>').value;
    LoadMap(u,1);
    //LoadMap("a70443@alunos.uminho.pt",1);
}
var map, mapOptions,count;
function LoadMap(email, agenda) {

    count = 0;

    var connection = new ActiveXObject("ADODB.Connection") ;

    var connectionstring="Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=<catalog>;User ID=<user>;Password=<password>;Provider=SQLOLEDB";

    connection.Open(connectionstring);
    var rs = new ActiveXObject("ADODB.Recordset");
    var command =   "SELECT Local FROM Tarefa WHERE fk_Agenda =".concat(agenda);
    rs.Open(command, connection);
    rs.MoveFirst;

    while(!rs.eof)
    {
        var connectionn = new ActiveXObject("ADODB.Connection") ;

        var connectionstringg ="Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=<catalog>;User ID=<user>;Password=<password>;Provider=SQLOLEDB";

        connectionn.Open(connectionstringg);
        var rs1 = new ActiveXObject("ADODB.Recordset");
        var command1 =   "SELECT Descricao, Coordenadas.ToString(), Cidade, Pais FROM Local WHERE Id = @Id".concat(rs.fields(0));
        rs1.Open(command1, connectionn);
        rs1.MoveFirst;


        var tit = rs1.fields(0);
        var desc =  rs1.fields(2).concat(",".concat(rs1.fields(3)));
        var coords = rs1.fields(1);
        var res = coord.split(",");
                
        var res1 = res[0].split( " " );
        var res2 = res[1].split( " " ); 

        
        var latitude = res1[0].substring(12,res1[0].length);
        var longitude = res2[0];


        markers[count] = { title: tit, description: desc, lat: latitude, lng: longitude };

        count = count + 1;


        rs.movenext;
    }

    rs.close;
    connection.close;



    var mapOptions = {
        center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
        zoom: 10,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
    var infoWindow = new google.maps.InfoWindow();
    var lat_lng = new Array();
    var latlngbounds = new google.maps.LatLngBounds();
    for (i = 0; i <count; i++) {
        var data = markers[i]
        var myLatlng = new google.maps.LatLng(data.lat, data.lng);
        lat_lng.push(myLatlng);
        var marker = new google.maps.Marker({
            position: myLatlng,
            map: map,
            title: data.title
        });
        latlngbounds.extend(marker.position);
        (function (marker, data) {
            google.maps.event.addListener(marker, "click", function (e) {
                infoWindow.setContent(data.description);
                infoWindow.open(map, marker);
            });
        })(marker, data);
    }
    map.setCenter(latlngbounds.getCenter());
    map.fitBounds(latlngbounds);

    //***********ROUTING****************//

    //Intialize the Path Array
    var path = new google.maps.MVCArray();

    //Intialize the Direction Service
    var service = new google.maps.DirectionsService();

    //Set the Path Stroke Color
    var poly = new google.maps.Polyline({ map: map, strokeColor: '#4986E7' });

    //Loop and Draw Path Route between the Points on MAP
    for (var i = 0; i < lat_lng.length; i++) {
        if ((i + 1) < lat_lng.length) {
            var src = lat_lng[i];
            var des = lat_lng[i + 1];
            path.push(src);
            poly.setPath(path);
            service.route({
                origin: src,
                destination: des,
                travelMode: google.maps.DirectionsTravelMode.DRIVING
            }, function (result, status) {
                if (status == google.maps.DirectionsStatus.OK) {
                    for (var i = 0, len = result.routes[0].overview_path.length; i < len; i++) {
                        path.push(result.routes[0].overview_path[i]);
                    }
                }
            });
        }
    }   
};

function SaveImg() {
    //URL of Google Static Maps.
    //Full Example, 
    // var staticMapUrl = "http://maps.googleapis.com/maps/api/staticmap?size=250x350&path=40.737102,-73.990318|40.749825,-73.987963|40.752946,-73.987384|40.755823,-73.986397&sensor=false ";
   
    var staticMapUrl = "http://maps.googleapis.com/maps/api/staticmap?size=250x350";
     
    //Loop and add Markers.
    for (var i = 0; i < markers.length; i++) {
        staticMapUrl += "&markers=color:red|" + markers[i].lat + "," + markers[i].lng;
    }

    //Set first markers path
    staticMapUrl += "&path=" + markers[0].lat + "," + markers[0].lng;

    //Loop and add rest of Markers.
    for (var i = 1; i < markers.length; i++) {
        staticMapUrl += "|" + markers[i].lat + "," + markers[i].lng;
    }

    //Set sensor
    staticMapUrl += "&sensor=false ";
    
    //Display the Image of Google Map.
    var imgMap = document.getElementById("imgMap");
    imgMap.src = staticMapUrl;
    imgMap.style.display = "block";
}
 
