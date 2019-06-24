<%@ Page Title="" Language="C#" MasterPageFile="~/Defualt.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Systems_Development.contact" %>

<asp:Content ID="contact" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>

        .background {
            width: 100%;
            height: 900px;
            background-image: url("img/background.jpeg");
            background-size: cover; /* <------ */
            background-repeat: no-repeat;
            background-position: center center;
            opacity: 0.5;
            padding: 50px 0px;
        }

        .wrapform {
         position:absolute;
         width:100%;
         height:600px;
         top:250px;

        }

        .container {
            max-width: 600px;
            margin: 0 auto;
            text-align: center;
            -webkit-border-radius: 6px;
            -moz-border-radius: 6px;
            border-radius: 6px;
            background-color: #FAFAFA;
             background-color: transparent;
               border: 1px solid #fff;
        
        }
        

        .head {
            -webkit-border-radius: 6px 6px 0px 0px;
            -moz-border-radius: 6px 6px 0px 0px;
            border-radius: 6px 6px 0px 0px;
            background-color: #2ABCA7;
            color: #FAFAFA;
             background-color: transparent;
          
                border: 1px solid transparent;
           
        }

        h3 {
            text-align: center;
            padding: 18px 0 18px 0;
            font-size: 1.4em;
        }

        input {
            margin-bottom: 10px;
             background-color: transparent;
            border: 1px solid #fff;
        }

            input:hover {
                 background-color: white;
                 transition:0.25s;
                 color:black;
          
            }

        textarea {
            height: 100px;
            margin-bottom: 10px;
             background-color: transparent;
            border: 1px solid #fff;
        }
           

        input:first-of-type {
            margin-top: 35px;
        }

        input, textarea {
            font-size: 1em;
            padding: 15px 10px 10px;
            font-family: 'Source Sans Pro',arial,sans-serif;
            border: 1px solid #cecece;
            background: #d7d7d7;
            color: #FAFAFA;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            -moz-background-clip: padding;
            -webkit-background-clip: padding-box;
            background-clip: padding-box;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 80%;
            max-width: 600px;
             background-color: transparent;
            border: 1px solid #fff;
        }
            textarea:hover {
                 background-color: white;
                 transition:0.25s;
                 color:black;
            }

       
button {
  margin-top:15px;
  margin-bottom:25px;
  background-color:#2ABCA7;
  padding: 12px 45px;
  -ms-border-radius: 5px;
  -o-border-radius: 5px;
  border-radius: 5px;
  border: 1px solid #2ABCA7;
  -webkit-transition: .5s;
  transition: .5s;
  display: inline-block;
  cursor: pointer;
  width:30%;
  color:#fff;
   background-color: transparent;
            border: 1px solid #fff;
}
button:hover, .button:hover {
  box-shadow: inset 200px 0 0 0 white;
  color: black;
}
label.error {
    font-family:'Source Sans Pro',arial,sans-serif;
    font-size:1em;
    display:block;
    padding-top:10px;
    padding-bottom:10px;
    background-color:#d89c9c;
    width: 80%;
    margin:auto;
    color: #FAFAFA;
    -webkit-border-radius:6px;
    -moz-border-radius:6px;
    border-radius:6px;
}
/* media queries */
@media (max-width: 700px) {
  label.error {
    width: 90%;
  }
  input, textarea {
    width: 90%;
     background-color: transparent;
            border: 1px solid #fff;
  }
  button {
    width:90%;
     background-color: transparent;
            border: 1px solid #fff;
  }
  body {
  padding-top:10px;
  }  
}
.message {
    font-family:'Source Sans Pro',arial,sans-serif;
    font-size:1.1em;
    display:none;
    padding-top:10px;
    padding-bottom:10px;
    background-color:#2ABCA7;
    width: 80%;
    margin:auto;
    color: #FAFAFA;
    -webkit-border-radius:6px;
    -moz-border-radius:6px;
    border-radius:6px;
     background-color: transparent;
            border: 1px solid #fff;

}
h4{
    font-family:'Roboto',sans-serif;
    font-size:30px;
    font-weight:lighter;
}

        .wrap {
            margin: 10px auto 0 auto;
            width: 100%;
            display: flex;
            align-items: space-around;
            max-width: 1300px;
            position:absolute;
            top:750px;
        }
        .card {
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    transition: 0.3s;
    width: 30%;
    padding: 1% 3.3%;
    color:black;

   
}



        .containerCard {
            transition: 0.25s;
            padding: 2px 16px;
            background-color: transparent;
            border: 1px solid #fff;
            text-align: center;
            outline: none;
            text-decoration: none;
            color: white;
            max-width: 600px;
            margin: 0 auto;
            text-align: center;
            -webkit-border-radius: 6px;
            -moz-border-radius: 6px;
            border-radius: 6px;
            color: #fff;
            font-family:'Roboto',sans-serif;
         
 
        }
            .containerCard:hover {
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.3);
    background-color:#fff;
    color:black;
            }

@media (max-width: 1000px) {
  .wrap {
   flex-direction: column;
    width:400px;
  }
}


</style>

   <div class ="background"></div>
    <div class="wrapform">  
  <div class="container">
    <div class="head">
      <h4>Send us a message</h4>
    </div>
    <input type="text" name="name" placeholder="Name" /><br />
    <input  type="email" name="email" placeholder="Email" /><br />
    <textarea type="text" name="message" placeholder="Message"></textarea><br />
    <div class="message">Message Sent</div>
    <button id="submit" type="submit">
      Send!
    </button>
  </div>
        </div>
        <div class="wrap">
              <link href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.3/css/font-awesome.css' rel='stylesheet' type='text/css'>
           
        <div class="card">
          
  
  <div class="containerCard">
        <div>
          <i style="font-size:150px; padding:10px" class="fa fa-map-marker"></i>
          
        </div>
    <h4><b>Find Us</b></h4> 
    <p>University of Greenwich</p> 
  </div>
</div>
            <div class="card">
          
  
  <div class="containerCard">
        <div>
           <i style="font-size:150px; padding:10px" class="fa fa-phone"></i>  
        </div>
    <h4><b>Call Us</b></h4> 
    <p>020 8331 8000</p> 
  </div>
</div>
            <div class="card">
          
  
  <div class="containerCard">
        <div>
         <i style="font-size:150px; padding:10px" class="fa fa-envelope"></i>
        </div>
    <h4><b>Email us</b></h4> 
    <p>mz7340g@gre.ac.uk</p> 
  </div>
</div>

</div>
       
   



</asp:Content>

