<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddVetbills.aspx.cs" Inherits="friendsWithPaws.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
     <div class="formAp" style="padding-bottom:70px; padding-top:20px;" >  
       <h1>Add Vet Bills to Pet</h1>
    <div class="space">

        <asp:Label ID="SpeciesLbl" runat="server" Text="Pet"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="petList" runat="server" Height="25px" Width="136px">
           <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
     
</div>
     <div class="space">
         

        <asp:Label ID="vaccinesLbl" runat="server" Text="Vaccines"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="vaccinesTxtBox" runat="server" Width="234px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="vaccinesTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
        
       </div>

      <div class="space">
        <asp:Label ID="n_ProcceduresLbl" runat="server" Text="Neutering Procedures"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="n_ProcceduresTxtBox" runat="server" Width="234px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="n_ProcceduresTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

      <div class="space">
        <asp:Label ID="id_chippingLbl" runat="server" Text="Id chipping"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="id_chippingTxtBox" runat="server" Width="234px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="id_chippingTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

     <div class="space">
        <asp:Label ID="flea_SprayingLbl" runat="server" Text="Flea Spraying"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="flea_SprayingTxtBox" runat="server" Width="234px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="flea_SprayingTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

            <div class="space">
        <asp:Label ID="wormingPillsLb" runat="server" Text="Worming Pills"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="wormingPillsTxtBox" runat="server" Width="234px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="wormingPillsTxtBox">* Fill in required Field </asp:RequiredFieldValidator>

       </div>
         <asp:Label ID="error" CssClass="error" runat="server" Text=""></asp:Label>
             <div class="space">
        <asp:Button ID="submit" CssClass="submit"  runat="server" Text="Submit" OnClick="submit_Click"  />
 <asp:Label CssClass="error" ID="success" runat="server" Text=""></asp:Label>
</div>

    </div>

  

</asp:Content>
