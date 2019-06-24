<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addSpecies.aspx.cs" Inherits="friendsWithPaws.addSpecies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formAp" style="padding-bottom:50px;" >

   <h1>Add Species</h1>



  <div class="space">  

<asp:GridView ID="addSpeciesGrid" runat="server" Caption="Current Table" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >  
     <AlternatingRowStyle BackColor="White" />  
     <columns>  
         <asp:TemplateField HeaderText="ID">  
             <ItemTemplate>  
                 <asp:Label ID="idLbl" runat="server" Text='<%#Bind("SpeciesID") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Species">  
             <ItemTemplate>  
                 <asp:Label ID="speciesLbl" runat="server" Text='<%#Bind("PetSpecie") %>'></asp:Label>  
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
      
       </div>

           <div class="space" style="margin-bottom:20%;">
  <asp:Label ID="speciesLbl" runat="server" Text="Species"></asp:Label>
       &nbsp;
            <asp:TextBox CssClass="textboxspace" ID="speciesTxtBox" runat="server" Width="234px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
            ControlToValidate="speciesTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
       &nbsp;
        <asp:Button ID="submit"  runat="server" Text="Submit" OnClick="submit_Click"  />
<asp:Label ID="error" runat="server" CssClass="error" Text=""></asp:Label>
</div>
       <%--</div>--%>

        

</asp:Content>
