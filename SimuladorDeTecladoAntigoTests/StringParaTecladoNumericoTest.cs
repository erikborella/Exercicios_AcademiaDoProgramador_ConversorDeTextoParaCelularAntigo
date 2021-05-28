using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using SimuladorDeTecladoAntigo;

namespace SimuladorDeTecladoAntigoTests
{
    [TestClass]
    public class StringParaTecladoNumericoTest
    {
        [TestMethod]
        public void DeveVerificarSEMPRE_ACESSO_O_DOJOPUZZLES()
        {
            string mensagem = "SEMPRE ACESSO O DOJOPUZZLES";

            StringParaTecladoNumerico stringParaTecladoNumerico = new StringParaTecladoNumerico(mensagem);

            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777",
                stringParaTecladoNumerico.MensagemEmNumeros);
        }

        [TestMethod]
        public void DeveVerificarAAAAA()
        {
            string mensagem = "AAAAA";

            StringParaTecladoNumerico stringParaTecladoNumerico = new StringParaTecladoNumerico(mensagem);

            Assert.AreEqual("2_2_2_2_2",
                stringParaTecladoNumerico.MensagemEmNumeros);
        }

        [TestMethod]
        public void DeveVerificarMensagemMuitoGrande()
        {
            string mensagem = "ijadsjdklasjdklasjdiqwjeioq2jeiqlwkwkljwqlkejqwlekjqwklcjixjcaispdmaspcnapscnapsncapsindpaisdnaipsdnapsidnasoneio12u81uj3ik2ln3 n12b3j12h3uo12hn3k12 3jhv12y3hu1io2lç312nmbg3vhy1hui2j3kl1m2n3 bgv21h3yuij2m13 nb21g3yhu21jik3l,1m 2n3bvg21y3uikl21,3m nnbv2gf13yuhi21k3, m12nb3fg1gt2yui3olk,12 m3nbv1gf23tyuiok2l1,.3";

            Assert.ThrowsException<ArgumentException>(() => { 
                new StringParaTecladoNumerico(mensagem);
            });
        }

        [TestMethod]
        public void DeveVerificarSimboloInvalido()
        {
            string mensagem = "abcd.,";

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                new StringParaTecladoNumerico(mensagem);
            });
        }
    }
}
