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

class WebServiceCEP
{
    public string BuscaCEP(string cep)
    {
        string CepLocalizado = "";

        //http://social.msdn.microsoft.com/forums/pt-br/vscsharppt/thread/D278DDA0-4A0D-4310-90C3-287C373A067A
        //* Verifica se o cep digitado é válido.

        Match regex = Regex.Match(cep, "^[0-9]{8}$");
        /**
         ** Se o CEP digitado for valido…
         */
        #region if
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
                //HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaEnderecoAction.do&#8221;);

                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaLogradouroAction.do?Metodo=listaLogradouro&CEP=&#8221;" + "TipoConsulta=cep");

                /**
                     * Define o que será postado
                     */
                //string postData = "relaxation=" + cep + "&TipoCep=ALL&semelhante=N&Metodo=listaLogradouro&TipoConsulta=relaxation&StartRow=1&EndRow=10&cfm=1″;
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
                //string responseText = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8″)).ReadToEnd();
                string responseText = new StreamReader(response.GetResponseStream(), Encoding.UTF7).ReadToEnd().ToString();
                /**Separa os dados com expressão regular
                 */
                MatchCollection matches = Regex.Matches(responseText, ">(.*?)</td>");
                /**
                 ** Exibe os dados recebidos
                 **
                 *@ RUA
                 *Passa o texto convertido para a textBox*/
                CepLocalizado += matches[0].Groups[1].ToString() + ";";
                /*@Bairro
                 */
                CepLocalizado += matches[1].Groups[1].ToString() + ";";                
            }
            catch (Exception err)
            {
                return CepLocalizado; 
            }
        }
        #endregion fim if
        return CepLocalizado;
    }
}
