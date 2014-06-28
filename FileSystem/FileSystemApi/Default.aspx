<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/FSMasterPage.Master"
    CodeBehind="Default.aspx.cs" Inherits="FileSystemApi.Default" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <title>ASP.NET Примерен проект</title>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="body">
    <div>
        <ol>
            <li>
                <asp:Button runat="server" ID="BtnXmlToDb" Text="Прехвърли XML файловете в БД" PostBackUrl="ProcessInfo.aspx" /></li>
            <li>
                <asp:HyperLink ID="HLinkInputData" NavigateUrl="UserInput.aspx" runat="server" Text="Въвеждане на данни" /></li>
        </ol>
    </div>
</asp:Content>

