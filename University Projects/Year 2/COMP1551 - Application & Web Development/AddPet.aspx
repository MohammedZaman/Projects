<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddPet.aspx.cs" Inherits="friendsWithPaws.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="formAp" >
         
   <h1> Add Pet</h1>
       
         
        <div class="space">
        <asp:Label ID="nameLbl" runat="server" Text="Name" ></asp:Label>
       &nbsp;

            <asp:TextBox CssClass="textboxspace" ID="nameTxtBox" runat="server" Width="234px"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="nameTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

       

        <div class="space">
        <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="genderDropDown" runat="server" Height="25px" Width="92px">
           <asp:ListItem></asp:ListItem>
           <asp:ListItem>Male</asp:ListItem>
           <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            
       </div>

         <div class="space">
        <asp:Label ID="sanctuaryLbl" runat="server" Text="Sanctuary"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="countryDD" runat="server" Height="25px" Width="92px">
           <asp:ListItem></asp:ListItem>
           <asp:ListItem>UK</asp:ListItem>
           <asp:ListItem>Romania</asp:ListItem>
           <asp:ListItem>Germany</asp:ListItem>
            </asp:DropDownList>
            
       </div>

           <div class="space">
        <asp:Label ID="SpeciesLbl" runat="server" Text="Species"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="SpeciesList" AutoPostBack="True" runat="server" Height="25px" Width="92px" OnSelectedIndexChanged="SpeciesList_SelectedIndexChanged">
           <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            
       </div>

            <div class="space">
        <asp:Label ID="breedLbl" runat="server" Text="Breed"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="breedDropDown" runat="server" Height="25px" Width="136px">
           <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            
       </div>

        <div class="space">
        <asp:Label ID="weightLbl" runat="server" Text="Weight"></asp:Label>
            &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="weightTxtBox" runat="server" Width="56px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="weightTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

         <div class="space">
        <asp:Label ID="ageWhenRescuedLbl" runat="server" Text="Age when rescued"></asp:Label>
            &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="ageWhenRescuedTxtBox" runat="server" Width="55px"></asp:TextBox>
       </div>

        <div class="space">
        <asp:Label ID="dateWhenRescuedLbl" runat="server" Text="Date When Rescued(dd/mm/yyyy) "></asp:Label>
            &nbsp;
            <asp:TextBox  CssClass="textboxspace" ID="dateWhenRescuedTxtBox" TextMode="Date" runat="server" Width="138px"></asp:TextBox>

          
       </div>
            <div>
               <br />
               <div class="space" >
        <asp:Label ID="uploadImageLbl" runat="server" Text="Upload Image"></asp:Label>
                   <asp:FileUpload ID="FileUpload1" CssClass="textboxspace"   runat="server" />

             </div>
      </div>
        <div class="space" style="width:100%;">
            <asp:Button ID="submit" CssClass="submit"  runat="server" Text="Submit" OnClick="submit_Click" />
            
        <h2><asp:Label ID="valid" runat="server" Text=""></asp:Label> </h2>

        </div>
       
        
       
    </div>

       




</asp:Content>
