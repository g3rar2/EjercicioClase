
using EjercicioClase;

SuperHeroe superheroe1 = new SuperHeroe();

superheroe1.nombre = "El Chapulin";
superheroe1.identidadSecreta = "Chespirito";
superheroe1.ciudad = "Ciudad de Mexico";
superheroe1.puedeVolar =true;
superheroe1.superPoder.nombre = "Plurilingüismo";
superheroe1.superPoder.descripcion = "Puede hablar y entender cualquier idioma del universo, excepto el de los críticos de cine.";
superheroe1.superPoder.nivel = 10;
superheroe1.Imprimir();


SuperHeroe superheroe2 = new SuperHeroe();

superheroe2.nombre = "Saint Seiya";
superheroe2.identidadSecreta = "Seiya";
superheroe2.ciudad = "Tokio";
superheroe2.puedeVolar = false;
superheroe2.superPoder.nombre = "Meteoro de Pegaso";
superheroe2.superPoder.descripcion = "Puede dar multiples golpes en rafaga.";
superheroe2.superPoder.nivel = 7;
superheroe2.Imprimir();


SuperHeroe superheroe3 = new SuperHeroe();

superheroe3.nombre = "Batman";
superheroe3.identidadSecreta = "Bruno Diaz";
superheroe3.ciudad = "Ciudad Gotica";
superheroe3.puedeVolar = false;
superheroe3.superPoder.nombre = "Inteligencia";
superheroe3.superPoder.descripcion = "Utiliza el conocimiento para inventar armas y herramientas";
superheroe3.superPoder.nivel = 5;
superheroe3.Imprimir();
