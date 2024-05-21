            void AgregarServicio () {
                    Console.WriteLine("Agregar un servicio.");
                    Console.WriteLine("1 Agregar un Entrenamiento Personalizado");
                    Console.WriteLine("2 Agregar una Clase Grupal");
                    Console.WriteLine("3 Agregar un suplemento");
                    Console.WriteLine("4 Volver al menu anterior");
                string? entrada = Console.ReadLine();
                while(entrada == null ||(entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4")){
                    
                    Console.WriteLine("Por favor Seleccione una de las opciones indicadas");
                    Console.WriteLine("Agregar un servicio.");
                    Console.WriteLine("1 Agregar un Entrenamiento Personalizado");
                    Console.WriteLine("2 Agregar una Clase Grupal");
                    Console.WriteLine("3 Agregar un suplemento");
                    Console.WriteLine("4 Volver al menu anterior");
                    entrada = Console.ReadLine();
                }
                int opcionSelect = int.Parse(entrada);
                switch(opcionSelect) {
                    case 1:
                    Console.Write("Ingresar tipo de entramiento: ");
                    string? tipoEntrenamiento = Console.ReadLine();
                    
                    while(string.IsNullOrEmpty(tipoEntrenamiento)){

                    Console.WriteLine("Por favor, ingrese el tipo de entrenamiento:");
                    tipoEntrenamiento = Console.ReadLine();
                    
                    }
                    
                    Console.WriteLine("Ingresar la duracion del entrenamiento en minutos");
                    string? duracionString = Console.ReadLine();
                    double duracion;
                    while(string.IsNullOrEmpty(duracionString) || !double.TryParse(duracionString,out duracion)){
                         Console.WriteLine("Por favor, ingrese una duración válida en minutos:");
                        duracionString = Console.ReadLine();
                    }
                    Console.WriteLine(duracion);
                    historial.AddService(new EntrenamientoPersonalizado(tipoEntrenamiento,duracion));
                    break;
                    //CASE 2
                    case 2 :
                    Console.WriteLine("Ingresar tipo de Clase");
                    string? tipoClase = Console.ReadLine();
                    while(string.IsNullOrEmpty(tipoClase)){

                    Console.WriteLine("Por favor, ingrese el tipo de clase:");
                    tipoClase = Console.ReadLine();
                    }
                    Console.WriteLine("Ingresar cantidad de inscriptos");
                    string? cantInscriptosString = Console.ReadLine();
                    double cantidadInscriptos;
                    while(string.IsNullOrEmpty(cantInscriptosString) || !double.TryParse(cantInscriptosString,out cantidadInscriptos)){
                         Console.WriteLine("Por favor, ingrese una duración válida en minutos:");
                        cantInscriptosString = Console.ReadLine();
                    }
                    Console.WriteLine("Ingresar la duracion del entrenamiento en minutos");
                    string? duracionStringClase = Console.ReadLine();
                    double duracionClase;
                    while(string.IsNullOrEmpty(duracionStringClase) || !double.TryParse(duracionStringClase,out duracionClase)){
                         Console.WriteLine("Por favor, ingrese una duración válida en minutos:");
                        duracionStringClase = Console.ReadLine();
                    }
                    historial.AddService(new ClaseGrupales(tipoClase,cantidadInscriptos,duracionClase));
                    break;
                    //
                    case 3: 
                    Console.WriteLine("Ingresa nombre del Suplemento");
                    string? nombre = Console.ReadLine();
                     while(string.IsNullOrEmpty(nombre)){

                    Console.WriteLine("Por favor, ingrese el nombre de suplemento:");
                    nombre = Console.ReadLine();
                    
                    }
                    Console.WriteLine("Ingresa el porcentaje de ganancia");
                    string? porcentajeString = Console.ReadLine();
                    double porcentajeGanancia;
                      while(string.IsNullOrEmpty(porcentajeString) || !double.TryParse(porcentajeString,out porcentajeGanancia)){
                         Console.WriteLine("Por favor, ingrese un porcentaje valido(numerico):");
                        porcentajeString = Console.ReadLine();
                    }
                    Console.WriteLine("Ingresa el precio de lista del Suplemento:");
                    string? precioListaString = Console.ReadLine();
                    double precioListaInt;
                      while(string.IsNullOrEmpty(precioListaString) || !double.TryParse(precioListaString,out precioListaInt)){
                         Console.WriteLine("Por favor, ingrese un precio de lista valido(numerico):");
                        precioListaString = Console.ReadLine();
                    }
                    historial.AddService(new Suplementos(nombre,porcentajeGanancia,precioListaInt));
                    break;
                    case 4:

                    break;
                    default:
                    Console.WriteLine("Ingresa una opcion valida.");
                    break;
                }
            }