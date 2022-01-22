<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="donor.pages.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Admin Login</title>
    <style type="text/css">
        .auto-style1 {
            width: 195px;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: left;
            width: 388px;
        }
        .auto-style3 {
            width: 388px;
        }
        .newStyle1 {
            font-family: "Times New Roman";
            font-size: x-large;
            font-weight: bolder;
            font-style: normal;
            font-variant: normal;
            text-transform: uppercase;
            color: #0000FF;
            text-decoration: underline;
        }
        .auto-style4 {
            width: 195px;
            height: 39px;
        }
        .auto-style5 {
            width: 388px;
            height: 39px;
        }
        .auto-style6 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:107%; height: 197px;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"><strong class="newStyle1">ADMIN LOGIN </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">Username&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtusername" runat="server" Width="176px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusername" ErrorMessage="Username required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">Password</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtpassword" runat="server" Width="176px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="89px" />
                    <br /><br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
