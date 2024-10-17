

using EjercicioClase;

SuperHeroe SuperHeroe = new SuperHeroe();
Superpoder Superpoder = new Superpoder();
SuperHeroe.Nombre = " Batman";
SuperHeroe.IdentidadSecreta = "Bruce wayne";
SuperHeroe.Ciudad = " Gothan";
SuperHeroe.PuedeVolar = false;
SuperHeroe.SuperPoder = " Ninguno pero le rompe la madre a quien sea,";
Superpoder.Descripcion = " Es inteligente y es millonario ,le rompio la madre a superman ";
Superpoder.Nivel = 10;
SuperHeroe.Imprimir();
Superpoder.Imprimir();

Console.WriteLine();

SuperHeroe SuperHeroe1 = new SuperHeroe();
Superpoder Superpoder1 = new Superpoder();
SuperHeroe1.Nombre = " Superman";
SuperHeroe1.IdentidadSecreta = " clark kent";
SuperHeroe1.Ciudad = " Metropolis";
SuperHeroe1.PuedeVolar =   true;
SuperHeroe1.SuperPoder = " Super fuerza , vision de calor, rapidez , aliento congelante, ";
Superpoder1.Descripcion = " Es pobre y trabaja en diario el planeta y batman le rompio la madre ";
Superpoder1.Nivel = 9;
SuperHeroe1.Imprimir();
Superpoder1.Imprimir();

Console.WriteLine();

SuperHeroe SuperHeroe2 = new SuperHeroe();
Superpoder Superpoder2 = new Superpoder();
SuperHeroe2.Nombre = " Flash ";
SuperHeroe2.IdentidadSecreta = " barry allen";
SuperHeroe2.Ciudad = " Central City";
SuperHeroe2.PuedeVolar = false;
SuperHeroe2.SuperPoder = " super velocidad y viajar en el tiempo";
Superpoder2.Descripcion = " Es inteligente y trabaja en un laborario para descubrir quien mato a la mama y sacar al papa de la carcel, batman lo pone quieto ";
Superpoder2.Nivel = 8;
SuperHeroe2.Imprimir();
Superpoder2.Imprimir();