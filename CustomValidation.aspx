<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidation.aspx.cs" Inherits="UsernameValidationApp.CustomValidation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Username Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:sans-serif; margin:50px;">
            <h2>Username Validation</h2>

            <asp:Label ID="lblUsername" runat="server" Text="Enter Username: "></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>

            <asp:CustomValidator ID="cvUsername" runat="server" 
                ControlToValidate="txtUsername"
                ErrorMessage="Only letters and numbers are allowed!"
                ForeColor="Red"
                OnServerValidate="cvUsername_ServerValidate"
                Display="Dynamic">
            </asp:CustomValidator>

            <br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

            <br /><br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
