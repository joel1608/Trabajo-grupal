using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.clases
{
    
        public class Nota
        {
            private string nombre;


            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }


            //actividad en clases 25%
            private float actuacionp1;

            public float ActuacionP1
            {
                get { return actuacionp1; }
                set
                {

                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");

                    actuacionp1 = value;


                }
            }


            //Produccion 25%
            private float produccionp1;

            public float ProduccionP1
            {

                get { return produccionp1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    produccionp1 = value;
                }
            }


            //traajo autonomo 20%

            private float trabajoautonomop1;

            public float TrabajoAutonomoP1
            {
                get { return trabajoautonomop1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    trabajoautonomop1 = value;
                }
            }

            //examen 30%
            private float examenfinalp1;

            public float ExamenFinalP1
            {
                get { return examenfinalp1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    examenfinalp1 = value;
                }
            }

            private float primerparcial;

            public float PrimerParcial
            {

                get
                {

                    return ActuacionP1 * 0.25f + ProduccionP1 * 0.25f + TrabajoAutonomoP1 * 0.2f + ExamenFinalP1 * 0.3f;

                }
            }

            private float actuacionp2;

            public float ActuacionP2
            {
                get { return actuacionp1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    actuacionp2 = value;
                }
            }


            //Produccion 25%
            private float produccionp2;

            public float ProduccionP2
            {
                get { return produccionp1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    produccionp2 = value;
                }
            }


            //traajo autonomo 20%

            private float trabajoautonomop2;

            public float TrabajoAutonomoP2
            {
                get { return trabajoautonomop1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    trabajoautonomop2 = value;
                }
            }

            //examen 30%
            private float examenfinalp2;

            public float ExamenFinalP2
            {
                get { return examenfinalp1; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10"); examenfinalp2 = value;
                }
            }

            private float segundoparcial;

            public float PSegundoParcial
            {

                get
                {

                    return ActuacionP2 * 0.25f + ProduccionP2 * 0.25f + TrabajoAutonomoP2 * 0.2f + ExamenFinalP2 * 0.3f;

                }



            }
            private float recuperacion;

            public float Recuperacion
            {
                get
                {

                    return 14 - (primerparcial + segundoparcial / 2);

                }

            }

            private float notareacuperacion;

            public float NotaRecuperacion
            {
                get { return notareacuperacion; }
                set
                {
                    if (value > 10 || value < 0)
                        throw new Exception("La nota debe estar entre 0 y 10");
                    notareacuperacion = value;
                }
            }


        }

    }

