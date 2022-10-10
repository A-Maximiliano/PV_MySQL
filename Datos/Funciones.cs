using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class Funciones
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private DataTable dt;

        //permite conectarnos a la base de datos
        MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=bd_punto_venta;User=root;Password=300717;port=3306");

        //Método de conexión
        public bool Conectar()
        {
            bool conectado = false;
            try
            {
                conexion.Open();
                conectado = true;
            }
            catch (MySqlException ex)
            {
                conectado = false; ;
            }
            finally
            {
                conexion.Close();
            }
            return conectado;
        }

        //Metodo para insertar valores
        public bool Insertar(string consulta)
        {
            bool agregado = false;
            int filas = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
 
            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch
            {
                filas = 0;
            }

            if (filas > 0)
            {
                agregado = true;
            }

            conexion.Close();
            return agregado;
        }

        //metodo para validar las credenciales del usuario el loguearse
        public int Ingresar(string usuario, string password)
        {
            int filas;
            conexion.Open();
            string consulta = "Select Count(*) from b_d_punto_venta_vendedores where Ced_Ven_B_D_Punto_Venta_Vendedores = '" + usuario + "'AND Cont_Ven_B_D_Punto_Venta_Vendedores = '" + password + "'";
            cmd = new MySqlCommand(consulta, conexion);
            // nos brinda el numero de registro en la tabla (devuelve 1 si existe el dato, caso contraio 0)
            filas = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return filas;
        }

        //metodo para obtener los valores consultados (se guardan en una lista)
        public List<string> ObtenerVendedor(string usuVend)
        { 
            conexion.Open();
            string consulta = " SELECT Ced_Ven_B_D_Punto_Venta_Vendedores , Nom_Ven_B_D_Punto_Venta_Vendedores FROM b_d_punto_venta_vendedores where `Ced_Ven_B_D_Punto_Venta_Vendedores` = '" + usuVend + "'";

            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            MySqlDataReader leer = cmd.ExecuteReader();

            List<string> vendedor = new List<string>();
            for (int i = 0; i < leer.FieldCount; i++)//fieldcount permite obtener la cantidad de valores de la consulta
            {
                try
                {
                    leer.Read().ToString();
                    string valor1 = leer[i].ToString();
                    vendedor.Add(valor1);
                }
                catch (Exception)
                {
                    conexion.Close();
                }
            }
            conexion.Close();
            return vendedor;
        }

        //metodo para obtener el nombre del liente de acuerdo al id digitado por el usuario
        public string ObtenerCliente(string clie)
        {
            conexion.Open();
            string usu = "";
            bool existe;
            string consulta = " SELECT `Nom_Clie_ B_D_Punto_Venta_Clientes` FROM b_d_punto_venta_clientes where `Nom_Clie_ B_D_Punto_Venta_Clientes` = '" + clie + "'";
            cmd = new MySqlCommand(consulta, conexion);
            MySqlDataReader leer = cmd.ExecuteReader();
            try
            {
                leer.Read().ToString();
                usu = leer[0].ToString();
                existe = true;
            }
            catch
            {
                existe = false;
            }   
            conexion.Close();
            return usu;    
        }

        //metodo para obtener los valores consultados (se guardan en una lista)
        public List<string> HacerConsulta(string consulta)
        {
            
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            //dt = new DataTable();
            //da.Fill(dt);
            MySqlDataReader leer = cmd.ExecuteReader();
            
            List<string> productos = new List<string>();
            for (int i = 0; i < leer.FieldCount; i++)
            {
                try
                {
                    leer.Read().ToString();
                    string valor1 = leer[i].ToString();
                    productos.Add(valor1);
                }
                catch (Exception)
                {

                    conexion.Close();
                }  
            }
            conexion.Close();
            return productos;
        }

        //Método de Recuperar contraseña
        public DataTable ConsultarDato(string consulta)
        {
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        //metodo para obtener los valores consultados (se guardan en una lista)
        public List<string> ConsultarDato1(string consulta)
        {
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);
            //dt = new DataTable();
            //da.Fill(dt);
            MySqlDataReader leer = cmd.ExecuteReader();

            List<string> productos = new List<string>();
            for (int i = 0; i < leer.FieldCount; i++)
            {
                try
                {
                    leer.Read().ToString();
                    string valor1 = leer[i].ToString();
                    productos.Add(valor1);
                }
                catch (Exception)
                {

                    conexion.Close();
                }
            }
            conexion.Close();
            return productos;
        }

        //metodo que permite realizar un update a la tabla
        public bool Modificar (string consulta)
        {
            //Se utiliza para verificar que el insert se haya ejecutado correctamente, por tanto se cambiará a true
            bool modificado = false;
            //se utfliza para guardar el número de filas afectas o encontradas por nuestra consulta,
            //si encutra una nos devuelve un 1, sino queda en 0.
            int filas = 0;
            //abrimos la conexión, ya heredada de la clase conexión
            conexion.Open();
            //Esto nos va a ejecutar la consulta en mysql
            cmd = new MySqlCommand(consulta, conexion);
            filas = cmd.ExecuteNonQuery();
            if (filas > 0)
            {
                modificado = true;
            }
            //si no cerramos la conexión solo permite agregar un valor
            conexion.Close();
            //Solo retornamos si es verdadero  
            return modificado;
        }

        //metodo que permite realizar un delete a la tabla
        public bool Eliminar(string consulta)
        {
            //Se utiliza para verificar que el insert se haya ejecutado correctamente, por tanto se cambiará a true
            bool eliminado = false;
            //se utfliza para guardar el número de filas afectas o encontradas por nuestra consulta,
            //si encutra una nos devuelve un 1, sino queda en 0.
            int filas = 0;
            //abrimos la conexión, ya heredada de la clase conexión
            conexion.Open();
            //Esto nos va a ejecutar la consulta en mysql
            cmd = new MySqlCommand(consulta, conexion);
            filas = cmd.ExecuteNonQuery();
            if (filas > 0)
            {
                eliminado = true;              
            }
            //si no cerramos la conexión solo permite agregar un valor
            conexion.Close();
            //Solo retornamos si es verdadero  
            return eliminado;
        }

        //metodo que permite registrar los datos en la tabla de facturacion
        public bool InsertarFacturacion(string consulta)
        {
            MySqlCommand Mcmd;
            MySqlDataAdapter Mda;
           
            bool agregado = false;
            int filas = 0;

            conexion.Open();
            Mcmd = new MySqlCommand(consulta, conexion);

            try
            {
                filas = Mcmd.ExecuteNonQuery();
            }
            catch
            {
                filas = 0;
            }

            if (filas > 0)
            {
                agregado = true;
            }

            conexion.Close();
            return agregado;
        }

        //permite obtener el siguiente numero de factura a ingresar
        public int IngresarNumFact1()
        {
            conexion.Open();
            string valor1 = "";
            int numFact = 1;
            string consulta = "select max(`Num_Fact_ B_D_Punto_Venta_Facturacion`) from b_d_punto_venta_facturacion";//selecciona el valor mas alto del campo Num Factura
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);

            MySqlDataReader leer = cmd.ExecuteReader();
                try
                {
                    leer.Read().ToString();
                    valor1 = leer[0].ToString();
                }
                catch (Exception)
                {
                    conexion.Close();
                }
            
            conexion.Close();
            numFact += Convert.ToInt32(valor1);
            return numFact;
        }
    }
}
