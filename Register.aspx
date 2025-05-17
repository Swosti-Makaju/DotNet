<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="YourNamespace.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 400px; margin: 50px auto; font-family: sans-serif;">
            <h2>User Registration</h2>

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Please fix the following errors:" />

            <label>Full Name:</label><br />
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFullName" runat="server" 
                ControlToValidate="txtFullName" 
                ErrorMessage="Full Name is required." 
                ForeColor="Red" Display="Dynamic" /><br /><br />

            <label>Email:</label><br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                ControlToValidate="txtEmail" 
                ErrorMessage="Email is required." 
                ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Enter a valid email address."
                ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
                ForeColor="Red" Display="Dynamic" /><br /><br />

            <label>Password:</label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                ControlToValidate="txtPassword" 
                ErrorMessage="Password is required." 
                ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revPassword" runat="server"
                ControlToValidate="txtPassword"
                ErrorMessage="Password must be at least 6 characters."
                ValidationExpression=".{6,}"
                ForeColor="Red" Display="Dynamic" /><br /><br />

            <label>Confirm Password:</label><br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" 
                ControlToValidate="txtConfirmPassword" 
                ErrorMessage="Please confirm your password." 
                ForeColor="Red" Display="Dynamic" />
            <asp:CompareValidator ID="cvPasswords" runat="server"
                ControlToCompare="txtPassword"
                ControlToValidate="txtConfirmPassword"
                ErrorMessage="Passwords do not match."
                ForeColor="Red" Display="Dynamic" /><br /><br />

            <label>Age:</label><br />
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAge" runat="server" 
                ControlToValidate="txtAge" 
                ErrorMessage="Age is required." 
                ForeColor="Red" Display="Dynamic" />
            <asp:RangeValidator ID="rvAge" runat="server"
                ControlToValidate="txtAge"
                ErrorMessage="Age must be between 18 and 99."
                MinimumValue="18"
                MaximumValue="99"
                Type="Integer"
                ForeColor="Red" Display="Dynamic" /><br /><br />

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /><br /><br />

            <asp:Label ID="lblSuccess" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
