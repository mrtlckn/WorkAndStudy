<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HW2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
         
            <br />
            <br />
            <br />
            <br />

            <asp:Panel ID="Panel_Login" runat="server">
                <div class="container">
                    <div class="row d-flex justify-content-center">
                        <aside class="col-sm-4">
                            <div class="card card-info border-info">
                                <article class="card-body">
                                    <h4 class="card-title text-center mb-10 mt-1">Hoşgeldiniz!</h4>
                                    <form>
                                        <div class="form-group">
                                            <asp:Label ID="lbl_first_name" runat="server" Text="Label">İsim:</asp:Label>
                                            <asp:TextBox ID="txtBox_first_name" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>

                                        <div class="form-group">
                                            <asp:Label ID="lbl_last_name" runat="server" Text="Label">Soyisim:</asp:Label>
                                            <asp:TextBox ID="txtBox_last_name" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>

                                        <div class="form-group">
                                            <asp:Button ID="btn_login" runat="server" Text="Login" type="submit" CssClass="btn btn-primary btn-block" OnClick="btn_login_Click" BackColor="#E3F2FD" BorderColor="#E3F2FD" ClientIDMode="Predictable" ForeColor="Black" />
                                        </div>

                                        <div class="form-group">
                                            <p class="text-center"><a href="#" class="btn">Parolanızı mı unutunuz? Buraya tıklayın</a></p>
                                        </div>

                                        <div class="form-group">
                                            <asp:Label ID="lbl_error" class="text-danger" runat="server"></asp:Label>
                                        </div>
                                    </form>
                                </article>
                            </div>
                        </aside>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="Panel_Info" runat="server">
                <div class="container">
                    <div class="row d-flex justify-content-center">
                        <aside class="col-sm-4">
                            <div class="card card-info border-info">
                                <article class="card-body">
                                    <h4 class="card-title text-center mb-10 mt-1">Daha önce giriş yaptınız!</h4>
                                    <form>

                                        <div class="form-group">
                                            <asp:Button ID="btn_go_default" runat="server" Text="Alışverişe Devam Et" type="submit" CssClass="btn btn-light btn-block btn-lg" BorderColor="#E3F2FD" ClientIDMode="Predictable" ForeColor="Black" OnClick="btn_continue_Click" />
                                        </div>
                                        <div class="form-group">
                                            <asp:Button ID="btn_ask_login" runat="server" Text="Çıkış Yap" type="submit" CssClass="btn btn-primary btn-block btn-lg" BackColor="#E3F2FD" BorderColor="#E3F2FD" ClientIDMode="Predictable" ForeColor="Black" OnClick="btn_ask_login_Click" />
                                        </div>

                                    </form>
                                </article>
                            </div>
                        </aside>
                    </div>
                </div>
            </asp:Panel>


        </div>
    </form>


    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
