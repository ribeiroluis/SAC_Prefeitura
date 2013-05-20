using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class BuscaCEP
{
    protected void BuscaCEP(string cep)
    {
        //http://social.msdn.microsoft.com/forums/pt-br/vscsharppt/thread/D278DDA0-4A0D-4310-90C3-287C373A067A
        //* Verifica se o cep digitado é válido.

        Match regex = Regex.Match(cep, "^[0-9]{8}$");
        /**
         ** Se o CEP digitado for valido…
         */

        if (regex.Success)
        {
            try
            {
                /**
                 * CEP a ser pesquisado
                 */
                string auxcep = cep;
                /**
                 *Cria a requisição
                 */
                //HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(“http://www.buscacep.correios.com.br/servicos/dnec/consultaEnderecoAction.do&#8221;);
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaLogradouroAction.do?Metodo=listaLogradouro&CEP=&#8221;" + "TipoConsulta=cep");/
                    /**
                     * Define o que será postado
                     *///string postData = “relaxation=” + cep + “&TipoCep=ALL&semelhante=N&Metodo=listaLogradouro&TipoConsulta=relaxation&StartRow=1&EndRow=10&cfm=1″;
                string postData = Request.ToString();
                
                /**
                 ** Converte a string de post para um ByteStream*/
                 //byte[] postBytes = Encoding.ASCII.GetBytes(postData);
                
                byte[] postBytes = Encoding.UTF7.GetBytes(postData.ToString());
                 
                /*
                  * Parâmetros da requisição
                  */
                Request.Method = "POST";
                Request.ContentType = "application/x-www-form-urlencoded";
                Request.ContentLength = postBytes.Length;
                Stream requestStream = Request.GetRequestStream();
                /**
                 * Envia Requisição
                 */
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();
                /**
                 * Resposta do servidor dos correios
                 */
                HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
                /**
                 ** String com a resposta do servidor
                 */

//http://social.msdn.microsoft.com/forums/pt-br/vscsharppt/thread/D278DDA0-4A0D-4310-90C3-287C373A067A

//string responseText = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(“utf-8″)).ReadToEnd();

string responseText = new StreamReader(response.GetResponseStream(), Encoding.UTF7).ReadToEnd().ToString();

/**

* Separa os dados com expressão regular

*/

MatchCollection matches = Regex.Matches(responseText, “>(.*?)</td>”);

/**

* Exibe os dados recebidos

*

* @ RUA

* Passa o texto convertido para a textBox

*

*/

txt_endereco.Text = matches[0].Groups[1].ToString();

/**

* @Bairro

*/

txt_bairro.Text = matches[1].Groups[1].ToString();

/**

* @Estado

*/

string estado =  HttpUtility.HtmlDecode(Convert.ToString(matches[3].Groups[1].ToString()));

if (estado != “” || estado != null)

{

var k = db.tb_estados.Where(v => v.Sigla.Equals(estado)).First();

ddl_estado.SelectedValue = Convert.ToString(k.EstadoId);

}

else

{

ddl_estado.SelectedValue = “26″;

this.Page.Response.Write(“<script>alert(‘Verifique se o CEP está correto!!’)</script>”);

return;

}

/**

* @Cidade

*/

PreecheCidades();

string cidade =  HttpUtility.HtmlDecode(Convert.ToString(matches[2].Groups[1].ToString()));

if (cidade != “” || cidade != null)

{

try

{

var data = (from o in db.tb_cidades

where o.Nome.StartsWith(cidade)

select o.CidadeId).First();

ddl_cidade.SelectedValue = Convert.ToInt32(data).ToString();

}

catch (Exception e)

{

this.Page.Response.Write(“<script>alert(‘” + e.Message + “: Cidade não existe’)</script>”);

}

}

else

{

ddl_cidade.SelectedValue = “9422″;

}

//——————————

/**

* @Cidade

*/

}

catch (Exception ex)

{

this.Page.Response.Write(“<script>alert(‘” + ex.Message + “‘)</script>”);

}

}

else

{

this.Page.Response.Write(“<script>alert(‘CEP inválido!’)</script>”);

}

}
}

