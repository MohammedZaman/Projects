<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewPetBills.aspx.cs" Inherits="friendsWithPaws.ViewPetBills" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formAp" style="padding-bottom:50px;" >

   <h1>View Pet Bills</h1>

        
  <div class="space">
      
<asp:GridView ID="addVetBillsGrid" CssClass="grid" runat="server" Caption="Current Table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" > 
  
     <AlternatingRowStyle BackColor="White" />  
     <columns>  
         <asp:TemplateField HeaderText="PetID">  
             <ItemTemplate>  
                 <asp:Label ID="idLbl" runat="server" Text='<%#Bind("PetID1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Pet Weight">  
             <ItemTemplate>  
                 <asp:Label ID="breedLbl" runat="server" Text='<%#Bind("PetWeight1") %>'></asp:Label>  
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

            <asp:TemplateField HeaderText="Vaccines">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("Vaccines") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 

         
            <asp:TemplateField HeaderText="Neutering Procedures">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("Neutering_Procedures1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 

         
            <asp:TemplateField HeaderText=" Id Chipping ">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("Id_Chipping1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 

                <asp:TemplateField HeaderText=" Flea Spraying ">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("Flea_Spraying1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 

               <asp:TemplateField HeaderText=" Worming Pills ">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("Worming_Pills1") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 

               <asp:TemplateField HeaderText=" Total Cost ">  
             <ItemTemplate>  
                 <asp:Label ID="housingCostLbl" runat="server" Text='<%#Bind("Total1") %>'></asp:Label>  
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
       <asp:Label ID="TotalLbl" CssClass="grandTotal" runat="server" Text="Label"></asp:Label>

    </div>
    
    </div>

    
</asp:Content>
