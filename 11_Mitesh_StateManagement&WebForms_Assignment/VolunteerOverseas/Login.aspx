<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VolunteerOverseas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Volunteer Overseas</title>
    <script src="https://code.jquery.com/jquery-3.1.1.js"></script>

    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(177deg, #4a7970, #4ea3a3);
            color: #2b5e61 !important;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        form {
            background: white;
            padding: 40px;
            border-radius: 12px;
            box-shadow: 41px 40px 21px rgba(43, 94, 97, 0.9);
            width: 350px;
            min-height: 320px;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
        }

        .loginMessage {
            font-size: 22px;
            font-weight: bold;
            margin-bottom: 20px;
            display: block;
        }

        input[type="text"], input[type="password"], input[type="submit"] {
            width: 89%;
            padding: 12px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 16px;
        }

        input[type="text"]:focus, input[type="password"]:focus {
            box-shadow: 0px 0px 10px rgba(78, 166, 171, 0.5);
            outline: none;
            border: 1px solid #4ea6ab;
            color: #2b5e61;
        }

        input[type="submit"] {
            background: #2b5e61;
            width: 97%;
            color: white;
            border: none;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background: #4ea6ab;
            box-shadow: 0px 4px 10px rgba(78, 166, 171, 0.6);
        }

        #LoginMsg {
            color: red;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" method="get">
        <div>
            <label class="loginMessage">Login to Volunteer Overseas</label>
            <label>Please enter username:</label>
            <input type="text" id="username" name="username" placeholder="Username" required />
            <label>Please enter password:</label>
            <input type="password" id="password" name="password" placeholder="Password" required />
            <input runat="server" type="submit" id="submitBtn" value="Login"  onserverclick="loginBtn" />
            <br />
            <br />
            <asp:Label runat="server" ID="LoginMsg"></asp:Label>
        </div>
    </form>
</body>
</html>
