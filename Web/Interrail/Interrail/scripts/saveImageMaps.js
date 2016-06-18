var markers = [
           {
               "title": 'Eiffel Tower',
               "lat": '48.858207',
               "lng": '2.294667',
               "description": 'Paris,France.'
           }
       ,
           {
               "title": 'National Monument',
               "lat": '52.372816',
               "lng": '4.893700',
               "description": 'Amsterdam,Netherlands.'
           }
      ,
           {
               "title": 'Anne Fran House',
               "lat": '52.375255',
               "lng": '4.883847',
               "description": 'Amsterdam,Netherlands.'
           }
      ,
           {
               "title": 'Siegestor',
               "lat": '48.152338',
               "lng": '11.582023',
               "description": 'Munchen,Germany.'
           }
      ,
           {
               "title": 'Colosseo',
               "lat": '41.890082',
               "lng": '12.492285',
               "description": 'Rome,Italy.'
           }
      ,
           {
               "title": 'The Motherland Calls',
               "lat": '48.742281',
               "lng": '44.536901',
               "description": 'Volgograd,Russia.'
           }
      ,
           {
               "title": 'Obelisk(Tolyatti)',
               "lat": '53.521136',
               "lng": '49.274878',
               "description": 'Tolyatti,Russia.'
           }
];

window.onload = function () {
    LoadMap();
}
var map, mapOptions;
function LoadMap() {
    var mapOptions = {
        center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
        zoom: 10,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
    var infoWindow = new google.maps.InfoWindow();
    var lat_lng = new Array();
    var latlngbounds = new google.maps.LatLngBounds();
    for (i = 0; i < markers.length; i++) {
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
 
