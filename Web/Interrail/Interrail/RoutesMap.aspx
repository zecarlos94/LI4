<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoutesMap.aspx.cs" Inherits="Interrail.RoutesMap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
     <link href="styles/RoutesMapStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
    <script type="text/javascript" src="scripts/saveImageMaps.js"></script>
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <div id="dvMap" style="width: 250px; height: 350px">
                </div>
            </td>
            <td>
                &nbsp; &nbsp;
            </td>
            <td>
                <img id="imgMap" alt="" style="display: none" />
            </td>
        </tr>
    </table>
    <br />
    <input type="button" id="btnExport" value="Export" onclick="SaveImg()" />
</body>
</html>
