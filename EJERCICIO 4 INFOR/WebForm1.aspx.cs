﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIO_4_INFOR
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.Params["nombre"].ToString();
            string edad = Request.Params["apellido"].ToString();
            Response.Write("<h1> Nombre:  " + nombre + "</h1>");
            Response.Write("<h1> Edad:   " + edad + "</h1> ");
        }
    }
}