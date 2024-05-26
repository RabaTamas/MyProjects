package filmtar;

import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.*;

import javax.swing.*;

public class SzerkesztoPanel extends BaseSzerkesztoPanel
{	
	private Film film;
	public boolean EditFilm(Film film)
	{
		boolean exception_happened = false;
		try
		{
			film.setCim(this.cim_tf.getText());
			this.cim_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.cim_tf.setBackground(Color.RED);
		}
		try
		{
			film.setEredetiCim(this.ecim_tf.getText());
			this.ecim_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.ecim_tf.setBackground(Color.RED);
		}
		
		try
		{
			film.setLeiras(this.leiras_tf.getText());
			this.leiras_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.leiras_tf.setBackground(Color.RED);
		}
		try
		{
			film.setMufaj(this.mufaj_tf.getText());
			this.mufaj_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.mufaj_tf.setBackground(Color.RED);
		}
		try
		{
			film.setRendezo(this.rendezo_tf.getText());
			this.rendezo_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.rendezo_tf.setBackground(Color.RED);
		}
		
		try
		{
			film.setEv(this.ev_tf.getText());
			this.ev_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.ev_tf.setBackground(Color.RED);
		}
		try
		{
			film.setKorhatar(this.korhatar_tf.getText());
			this.korhatar_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.korhatar_tf.setBackground(Color.RED);
		}
		try
		{
			film.setHossz(this.hossz_tf.getText());
			this.hossz_tf.setBackground(Color.WHITE);
		}
		catch(Exception ex)
		{
			exception_happened = true;
			this.hossz_tf.setBackground(Color.RED);
		}
		if(exception_happened)
			return exception_happened;
		film.setBorito(this.borito_tf.getText());
		this.cim_tf.setText("");
		this.ecim_tf.setText("");
		this.mufaj_tf.setText("");
		this.leiras_tf.setText("");
		this.rendezo_tf.setText("");
		this.ev_tf.setText("");
		this.korhatar_tf.setText("");
		this.hossz_tf.setText("");
		this.borito_tf.setText("");
		return false;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getActionCommand()== "MEGSE")
			mf.getCardLayout().show(mf.getCards(), "FILM");
		if(e.getActionCommand()== "MENTES")
		{
			if(EditFilm(this.film) == true)
				return;
			mf.getAdatPanel().SetData(film);
			mf.getCardLayout().show(mf.getCards(), "FILM");
		}
		
	}
	public  SzerkesztoPanel(MainFrame mf)
	{
		super(mf);
	}
	public void setFilm(Film f)
	{
		this.film = f;
		this.cim_tf.setText(f.getCim());
		this.ecim_tf.setText(f.getEredetiCim());
		this.mufaj_tf.setText(f.getMufaj());
		this.leiras_tf.setText(f.getLeiras());
		this.rendezo_tf.setText(f.getRendezo());
		this.ev_tf.setText(String.valueOf(f.getEv()));
		this.hossz_tf.setText(String.valueOf(f.getHossz()));
		this.korhatar_tf.setText(String.valueOf(f.getKorhatar()));
		this.borito_tf.setText(f.getBorito());
	}
	
	public Film getFilm() {
		return this.film;
	}
}