<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addBreed.aspx.cs" Inherits="friendsWithPaws.addBreed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formAp" style="padding-bottom:50px;" >

   <h1>Add Breed</h1>

        
  <div class="space">
      
<asp:GridView ID="addBreedGrid" CssClass="grid" runat="server" Caption="Current Table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" > 
  
     <AlternatingRowStyle BackColor="White" />  
     <columns>  
         <asp:TemplateField HeaderText="ID">  
             <ItemTemplate>  
                 <asp:Label ID="idLbl" runat="server" Text='<%#Bind("BreedID") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Breed">  
             <ItemTemplate>  
                 <asp:Label ID="breedLbl" runat="server" Text='<%#Bind("Breed") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  

             <asp:TemplateField HeaderText="FoodCostPerKG">  
             <ItemTemplate>  
                 <asp:Label ID="foodLbl" runat="server" Text='<%#Bind("FoodCostPerKG1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  

          <asp:TemplateField HeaderText="HousingCosts">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("HousingCosts1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 

     </columns>  
     <EditRowStyle BackColor="#2461BF" />  
     <FooterStyle BackColor="#507CD1" Font-Bold="false" ForeColor="White" />  
     <HeaderStyle BackColor="#507CD1" Font-Bold="false" ForeColor="White" />  
     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />  
     <RowStyle BackColor="#EFF3FB" />  
     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="false" ForeColor="#333333" />  
     <SortedAscendingCellStyle BackColor="#F5F7FB" />  
     <SortedAscendingHeaderStyle BackColor="#6D95E1" />  
     <SortedDescendingCellStyle BackColor="#E9EBEF" />  
     <SortedDescendingHeaderStyle BackColor="#4870BE" />  
 </asp:GridView>  
</div>

      <div class="space">
        <asp:Label ID="SpeciesLbl" runat="server" Text="Species"></asp:Label>
       &nbsp;<asp:DropDownList CssClass="textboxspace" ID="speciesDD" AutoPostBack="True" runat="server" Height="25px" Width="92px">
           <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            
        </div>    
      

    <div class="space">
        <asp:Label ID="breedLbl" runat="server" Text="Breed"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="breedTxtBox" runat="server" Width="234px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="breedTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>
    
    <div class="space">
        <asp:Label ID="foodCostLbl" runat="server" Text="Food cost Per KG"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="foodCostTxtBox" runat="server" Width="234px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="foodCostTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

    
    <div class="space">
        <asp:Label ID="housingCostLbl" runat="server" Text="Housing Cost"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="housingCostTxtBox" runat="server" Width="234px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="housingCostTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       </div>

     <div class="space">
        <asp:Button ID="submit" CssClass="submit"  runat="server" Text="Submit" OnClick="submit_Click"  />
<asp:Label ID="error" CssClass="error" runat="server" Text=""></asp:Label>
</div>
        



    </div>
</asp:Content>
