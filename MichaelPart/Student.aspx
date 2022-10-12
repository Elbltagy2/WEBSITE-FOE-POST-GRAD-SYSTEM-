<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="MichaelPart.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aqua">
    <form id="form1" runat="server">
        <div id="div">
            <h4>Your Thesis</h4>
            <asp:Table id="Table1" 
        GridLines="Both" 
        HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0" 
        Runat="server"/>
        </div>
        <div >
            <h4>Your info</h4>
            <asp:Table id="Table2" 
        GridLines="Both" 
        HorizontalAlign="left" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0" 
        Runat="server"/>
        </div>
        <div>
            <h4 id="course" runat="server" class="modal-body" style="text-align: center;"></h4>
            <asp:Table id="Table3" 
        GridLines="Both" 
        HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0" 
        Runat="server"/>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="348px" style="margin-top: 45px" Width="618px">
            Thesis serial number :<asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
            <br />
            Date
            <asp:Calendar ID="Calendar1" runat="server" Height="104px"></asp:Calendar>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
