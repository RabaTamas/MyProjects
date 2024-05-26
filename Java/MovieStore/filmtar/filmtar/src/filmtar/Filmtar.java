package filmtar;

import java.io.EOFException;
import java.io.FileInputStream;
import java.io.InputStream;
import java.io.ObjectInputStream;
import java.util.*;

import junit.framework.ComparisonCompactor;
//import Film;
public class Filmtar extends Tar<Film>
{
	@Override
	public void add(Film f) {
		super.add(f);
		super.sort((x,y)->(x.getCim().compareTo(y.getCim())));
	}
	
	public void load(String filenev) throws Exception
	{
		try
		{
			InputStream fis = new FileInputStream(filenev);
			ObjectInputStream ois = new ObjectInputStream(fis);
			while(true)
			{
				try
				{
					Object o = ois.readObject();
					if(o == null) break;
					else
						tar.add((Film)o);
				}
				catch(EOFException e)
				{
					//e.printStackTrace();
					break;
				}
				
			}
		}
		catch(Exception e)
		{
			//e.printStackTrace();
			throw e;
		}
		
	}
	
	public ArrayList<Film> Search(String keresett) {
		ArrayList<Film> results = new ArrayList<>();
		for(Film f: this.tar)
		{
			if(f.getCim().startsWith(keresett))
			{
				results.add(f);
			}		
		}
		return results;
	}
}
