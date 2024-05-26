package filmtar;
import java.io.*;
public class Film implements Serializable
{
	private String cim, eredeti_cim, mufaj, leiras, rendezo;
	private int ev, hossz, korhatar;
	private String borito;
	public Film()
	{
	
	}
	public Film(String cim, String eredeti_cim, String mufaj, String leiras, String rendezo,String ev, String hossz, 
			String korhatar, String borito) throws Exception
	{
		this.cim = cim;
		this.eredeti_cim = eredeti_cim;
		this.mufaj = mufaj;
		this.leiras = leiras;
		this.rendezo = rendezo;
		try
		{
			this.ev = Integer.parseInt(ev);
			this.hossz = Integer.parseInt(hossz);
			this.korhatar = Integer.parseInt(korhatar);
		}
		catch(Exception ex)
		{
			throw ex;
		}
		this.borito = borito;
	}
	public String getCim()
	{
		return cim;
	}
	public String getEredetiCim()
	{
		return eredeti_cim;
	}
	public String getBorito()
	{
		return borito;
	}
	public String getMufaj()
	{
		return mufaj;
	}
	public String getLeiras()
	{
		return leiras;
	}
	public String getRendezo()
	{
		return rendezo;
	}
	public int getEv()
	{
		return ev;
	}
	public int getHossz()
	{
		return hossz;
	}
	public int getKorhatar()
	{
		return korhatar;
	}
	public void setCim(String cim) throws Exception
	{
		if(cim.equals(""))
			throw new Exception();
		this.cim = cim;
	}
	public void setEredetiCim(String ecim) throws Exception
	{
		if(ecim.equals(""))
			throw new Exception();
		this.eredeti_cim = ecim;
	}
	
	public void setMufaj(String mufaj) throws Exception
	{
		if(mufaj.equals(""))
			throw new Exception();
		this.mufaj = mufaj;
	}
	public void setLeiras(String leiras) throws Exception
	{
		if(leiras.equals(""))
			throw new Exception();
		this.leiras = leiras;
	}
	public void setRendezo(String rendezo) throws Exception
	{
		if(rendezo.equals(""))
			throw new Exception();
		this.rendezo = rendezo;
	}
	
	public void setEv(String ev) throws NumberFormatException
	{
		try
		{
			this.ev = Integer.parseInt(ev);
		}
		catch(Exception e)
		{
			throw e;
		}
	}
	public void setKorhatar(String korhatar) throws NumberFormatException
	{
		try
		{
			this.korhatar = Integer.parseInt(korhatar);
		}
		catch(Exception e)
		{
			throw e;
		}
	}
	public void setHossz(String hossz) throws NumberFormatException
	{
		try
		{
			this.hossz = Integer.parseInt(hossz);
		}
		catch(Exception e)
		{
			throw e;
		}
	}
	public void setBorito(String borito)
	{
		this.borito = borito;
	}
}