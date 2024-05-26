package filmtar;

import java.io.*;

public class Main 
{
	public static void main(String[] args)
	{
		//Film a = new Film("A tegla", "The Departed", "drama", "a", "Martin Scorsese", 2006, 152, 16,"tegla.jpg");
		//Film b = new Film("A keresztapa", "The Godfather", "drama", "a", "Francis Ford Coppola", 1972, 175, 16,"A_Keresztapa.png");
		//Film c = new Film("Gladiator", "Gladiator", "akciofilm", "a", "Ridley Scott", 2000, 155, 16,"gladiator.jpg");
		//tar.add(a);
		//tar.add(c);
		//tar.add(b);
		try {
			MainFrame mf = new MainFrame("film.txt");
		}
		catch(Exception e) {
			e.printStackTrace();
		}
	}
}