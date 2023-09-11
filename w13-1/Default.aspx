<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="w13_1.Automobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <%--DROPDOWNLIST IMAGE  --%>
        <div class="d-flex justify-content-between m-4 ">
            <asp:DropDownList CssClass="btn btn-dark text-ligth mt-5 " ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" Height="36px">
                <asp:ListItem Value="Dacia.png" Text="Dacia Portugal" />
                <asp:ListItem Value="fiat.png"  Text="Fiat 500" />
                <asp:ListItem Value="jeep-renegade.png"  Text="Jeep Renagade" />
            </asp:DropDownList>
            <div>
            <asp:ImageMap ID="ImageMap1" Width="250px" runat="server"></asp:ImageMap>
            <h4 runat="server" id="result"></h4>

            </div>
       </div>

          <%--CHECKLIST --%>
        <h2 class="m-4">Optional</h2>
       <div class="border border-dark m-4  rounded-3 ">
            <asp:CheckBoxList CssClass="m-3 d-flex justify-content-center" ID="CheckBoxList1" runat="server" RepeatColumns="2" on>
                <asp:ListItem Value="330" Text="Vernice metallizzata (costo euro 330,00)" />
                <asp:ListItem Value="180"  Text=" Fari Xeno (costo euro 180,00)" />
                <asp:ListItem Value="1800"  Text="Sistema navigazione satellitare (costo euro 1.800,00)" />
                <asp:ListItem Value="2000"  Text="Line Assistant (costo euro 2.000,00)" />
                <asp:ListItem Value="155"  Text="Ruota di scorta (costo euro 155,00)" />
                <asp:ListItem Value="700"  Text="Sedili/volante in pelle (costo euro 700,00)" />
            </asp:CheckBoxList>
          
      </div>

        <%-- DROPDOWNLIST --%>
         <div class="d-flex justify-content-center  m-4 ">
             <h5>Anni di garanzia:</h5>
     <asp:DropDownList CssClass="btn border-dark m-0 " ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true" Height="36px">
         <asp:ListItem Value="1" Text="1 anno" />
         <asp:ListItem Value="2"  Text="2 anni" />
         <asp:ListItem Value="3"  Text="3 anni" />
         <asp:ListItem Value="4"  Text="4 anni" />
     </asp:DropDownList>

</div>
       <asp:Button ID="Button1" CssClass="btn btn-info mx-auto" runat="server" Text="Button" OnClick="Button1_Click" />
        <%-- TOTALI --%>
        <div>
        <p runat="server" id="macchina"></p>
        <p runat="server" id="optional"></p>
        <p runat="server" id="garanzia"></p>
        <p runat="server" id="totale"></p>
    

        </div>
    </form>
</body>
</html>
