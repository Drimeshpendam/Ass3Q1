<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your name"></asp:TextBox>
<br />
<asp:RadioButton ID="rbtnYellow" runat="server" Text="Yellow" GroupName="Color" />
<asp:RadioButton ID="rbtnCyan" runat="server" Text="Cyan" GroupName="Color" />
<asp:RadioButton ID="rbtnLime" runat="server" Text="Lime" GroupName="Color" />
<asp:RadioButton ID="rbtnGray" runat="server" Text="Gray" GroupName="Color" />
<br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

        </div>
    </form>

</body>
</html>
