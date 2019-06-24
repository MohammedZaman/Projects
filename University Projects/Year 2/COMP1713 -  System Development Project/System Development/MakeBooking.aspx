<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="MakeBooking.aspx.cs" Inherits="Systems_Development.MakeBooking" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">

 <div class="form"  >

            <h2>Make Booking</h2>
 
      <div class="space">
          
 <div id="map">
      </div>
      </div>
    
        <div class="space">
        <asp:Label ID="carLbl" runat="server" Text="Vehicle" Width="30%"></asp:Label>
       &nbsp;
            <asp:DropDownList CssClass="textboxspace" ID="carDropDown" runat="server" Height="35px" style="Width:62%">
            <asp:ListItem>Select Option</asp:ListItem>
           <asp:ListItem>Standard(4 Passengers)</asp:ListItem>
           <asp:ListItem>Standard XL(6 Passengers)</asp:ListItem>
            </asp:DropDownList>
            
       </div>

     <div class="space">
           <asp:Label ID="pickUpLbl" runat="server" Text="Pick Up location" Width="30%"></asp:Label>
            &nbsp;
         <input type="text" class="textboxspace " placeholder="Enter Pick-up point" id="pac-input" name="pick-up" style="Width:60%"  />
     </div>

        <div class="space">
           <asp:Label ID="dropOffLbl" runat="server" Text="Drop Off location" Width="30%"></asp:Label>
            &nbsp;
           
         <input type="text"  class="textboxspace "  id="Drop-off"  placeholder="Where to?"  name="drop-off" style="Width:60%"  />
     </div>
            <div class="space">
           <asp:Label ID="validationLbl" style="Color: red" runat="server" Width="50%" ></asp:Label>

     </div>




     <div class="space" >
             <asp:Button autopostback="false" ID="MakeBookingBtn"  CssClass="button" width="40%" style="margin-right:10px;"  runat="server" Text="Make booking" OnClick="MakeBookingBtn_Click"  OnClientClick="myfunctionx(); return false;"  />
        

        </div>


     
     </div>

          
   <div id="myModal" class="modal">

  <!-- Modal content -->
  <div class="modal-content">
    <div class="modal-header">
      <span class="close">&times;</span>
      <h3 style="text-align:center;">Confirmation</h3>
      
    </div>
    <div class="modal-body">

    <div class="creditCard">
          <div class="space"> 
         <asp:Label ID="discountLbl" runat="server" Text="15% Discount Applied " ForeColor="Red" Width="60%"></asp:Label>
            &nbsp;


    </div>    

    <div class="space"> 
         <asp:Label ID="message1Lbl" runat="server" Text="" Width="60%"></asp:Label>
            &nbsp;


    </div>
           <div class="space"> 
         <asp:Label ID="message2Lbl" runat="server" Text="" Width="60%"></asp:Label>
            &nbsp;


    </div>

            <div class="space"> 
         <asp:Label ID="message3Lbl" runat="server" Text="" Width="60%"></asp:Label>
            &nbsp;


    </div>

       <div class="space" >
             <asp:Button ID="Confrim" CssClass="button" width="25%" style="margin-right:10px; "  runat="server" Text="Ok" OnClick="ConfrimBtn_Click" />
       

        </div>    

    </div>
   </div>
    <div class="modal-footer">
      <h3>Private Hire</h3>
    </div>
  </div>

</div>

    <style>
        @import url(https://fonts.googleapis.com/css?family=Raleway:200,600,700,400);
        .creditCard {
            padding:50px 20px;


        }
      /* The Modal (background) */
.modal {
    font-weight: 400;
  font-size: 1em;
  font-family: 'Raleway', Arial, sans-serif;
    display: none; /* Hidden by default */
    position: fixed; /* Stay in place */
    z-index: 1; /* Sit on top */
    padding-top: 10%; /* Location of the box */
    font-size:20px;
    left: 0;
    top: 0;
    width: 100%; /* Full width */
    height: 100%; /* Full height */
    overflow: auto; /* Enable scroll if needed */
    background-color: rgb(0,0,0); /* Fallback color */
    background-color: rgba(0,0,0,0.5); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
    position: relative;
    background-color: #fefefe;
    margin: auto;
    padding: 0;
    border: 1px solid #888;
    width: 50%;
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
    -webkit-animation-name: animatetop;
    -webkit-animation-duration: 0.4s;
    animation-name: animatetop;
    animation-duration: 0.4s
}

/* Add Animation */
@-webkit-keyframes animatetop {
    from {top:-300px; opacity:0} 
    to {top:0; opacity:1}
}

@keyframes animatetop {
    from {top:-300px; opacity:0}
    to {top:0; opacity:1}
}

/* The Close Button */
.close {
    color: white;
    float: right;
    font-size: 28px;
    font-weight: bold;
}

.close:hover,
.close:focus {
    color: #000;
    text-decoration: none;
    cursor: pointer;
}

.modal-header {
    padding: 2px 16px;
    background-color: #464646;
    color: white;
}

.modal-body {padding: 2px 16px;}

.modal-footer {
    padding: 2px 16px;
    background-color: #464646;
    color: white;
}



    </style>

    <script>
// Get the modal
var modal = document.getElementById('myModal');

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal 
function openModel() {
    modal.style.display = "block";
         
        }

        function closeModel() {
            modal.style.display = "none";
        }



// When the user clicks on <span> (x), close the modal
span.onclick = function() {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
</script>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>

     
  
 
<script type="text/javascript" src="js/Map.js"></script>
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD7WJ5NTe1qqa7tfPiLgCroI2T4p-bHdx8&signed_in=true&libraries=places&callback=initAutocomplete" async></script>

</asp:Content>
