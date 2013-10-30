using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class KeyboardController : Controller
    {
        public Button A = new Button(),
                      B = new Button(),
                      C = new Button(),
                      D = new Button(),
                      E = new Button(),
                      F = new Button(),
                      G = new Button(),
                      H = new Button(),
                      I = new Button(),
                      J = new Button(),
                      K = new Button(),
                      L = new Button(),
                      M = new Button(),
                      N = new Button(),
                      O = new Button(),
                      P = new Button(),
                      Q = new Button(),
                      R = new Button(),
                      S = new Button(),
                      T = new Button(),
                      U = new Button(),
                      V = new Button(),
                      W = new Button(),
                      X = new Button(),
                      Y = new Button(),
                      Z = new Button();

        public override void Update()
        {
            base.Update();

            A.Enabled = Enabled;
            B.Enabled = Enabled;
            C.Enabled = Enabled;
            D.Enabled = Enabled;
            E.Enabled = Enabled;
            F.Enabled = Enabled;
            G.Enabled = Enabled;
            H.Enabled = Enabled;
            I.Enabled = Enabled;
            J.Enabled = Enabled;
            K.Enabled = Enabled;
            L.Enabled = Enabled;
            M.Enabled = Enabled;
            N.Enabled = Enabled;
            O.Enabled = Enabled;
            P.Enabled = Enabled;
            Q.Enabled = Enabled;
            R.Enabled = Enabled;
            S.Enabled = Enabled;
            T.Enabled = Enabled;
            U.Enabled = Enabled;
            V.Enabled = Enabled;
            W.Enabled = Enabled;
            X.Enabled = Enabled;
            Y.Enabled = Enabled;
            Z.Enabled = Enabled;
        }

        public static KeyboardController GetKeyboard()
        {
            var Controller = new KeyboardController();

            Controller.A.AddButton(0);
            Controller.B.AddButton(1);

            return Controller;
        }
    }
}
