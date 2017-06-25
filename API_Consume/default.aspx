<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="API_Consume._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        table
        {
            border: 0px solid #ccc;
        }
        table
        {
            border: 1px solid #ccc;
            border-collapse: collapse;
        }
        table th
        {
            padding: 5px;
            border: 1px solid #ccc;
        }
        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
        table td
        {
            padding: 5px;
            border: 1px solid #ccc;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="txtCity" runat="server" Text="" />
    <asp:Button Text="Get Weather Information" runat="server" OnClick="GetWeatherInfo" ID="Button1" />
    <hr />
    <table id="tblWeather" runat="server" border="0" cellpadding="0" cellspacing="0"
        visible="false">
        <tr>
            <th colspan="2">
                Weather Information
            </th>
        </tr>
        <tr>
            <td rowspan="3">
                <asp:Image ID="imgWeatherIcon" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCity_Country" runat="server" />
                <asp:Image ID="imgCountryFlag" runat="server" />
                <asp:Label ID="lblDescription" runat="server" />
                Humidity:
                <asp:Label ID="lblHumidity" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Temperature: (Min:
                <asp:Label ID="lblTempMin" runat="server" />
                Max:
                <asp:Label ID="lblTempMax" runat="server" />
                Day:
                <asp:Label ID="lblTempDay" runat="server" />
                Night:
                <asp:Label ID="lblTempNight" runat="server" />)
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
