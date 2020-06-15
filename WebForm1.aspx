<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StoredProcWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>World</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Hello</p>
        </div>
        <input type="text" runat="server" class="form-control" id="PurchaseOrderID" placeholder="Enter" />
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" />
        <asp:GridView ID="searchResults" runat="server">

        </asp:GridView>
    </form>


</body>
</html>
