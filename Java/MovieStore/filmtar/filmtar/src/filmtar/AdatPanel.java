package filmtar;

import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class AdatPanel extends JPanel implements ActionListener{
	private MainFrame mf;
	
	private Film film;
	private String defaultimage;
	private JLabel cim_jl, ecim_jl, mufaj_jl, leiras_jl, rendezo_jl, ev_jl, hossz_jl, korhatar_jl;
	private JLabel kep;
	
	public AdatPanel(MainFrame mf, String defaultimage) {
		this.mf = mf; 
		this.defaultimage = defaultimage;
		JPanel filmadatok = new JPanel();
		filmadatok.setLayout(new GridLayout(9,2));
		JLabel cim = new JLabel("Cim:");
		JLabel ecim = new JLabel("Eredeti cim:");
		JLabel mufaj = new JLabel("Mufaj:");
		JLabel leiras = new JLabel("Leiras:");
		JLabel rendezo = new JLabel("Rendezo:");
		JLabel ev = new JLabel("Ev:");
		JLabel hossz = new JLabel("Hossz:");
		JLabel korhatar = new JLabel("Korhatar:");
		cim_jl = new JLabel();
		ecim_jl = new JLabel();
		mufaj_jl = new JLabel();
		leiras_jl = new JLabel();
		rendezo_jl = new JLabel();
		ev_jl = new JLabel();
		hossz_jl = new JLabel();
		korhatar_jl = new JLabel();
		filmadatok.add(cim);
		filmadatok.add(cim_jl);
		filmadatok.add(ecim);
		filmadatok.add(ecim_jl);
		filmadatok.add(mufaj);
		filmadatok.add(mufaj_jl);
		filmadatok.add(leiras);
		filmadatok.add(leiras_jl);
		filmadatok.add(rendezo);
		filmadatok.add(rendezo_jl);
		filmadatok.add(ev);
		filmadatok.add(ev_jl);
		filmadatok.add(hossz);
		filmadatok.add(hossz_jl);
		filmadatok.add(korhatar);
		filmadatok.add(korhatar_jl);
		kep = new JLabel();
		this.add(kep);
		
		JPanel jobbPanel = new JPanel();
		jobbPanel.setLayout(new BorderLayout());
		jobbPanel.add(filmadatok, BorderLayout.NORTH);
		//jobbPanel.add(filmadatok, BorderLayout.NORTH);
		JPanel gombPanel = new JPanel();
		
		JButton bback = new JButton("Vissza");
		bback.addActionListener(this);
		bback.setActionCommand("Vissza");
		JButton bedit = new JButton("Szerkesztes");
		bedit.addActionListener(this);
		bedit.setActionCommand("Szerkesztes");
		JButton bdel = new JButton("Torles");
		bdel.addActionListener(this);
		bdel.setActionCommand("Torles");
		gombPanel.add(bback);
		gombPanel.add(bedit);
		gombPanel.add(bdel);
		jobbPanel.add(gombPanel, BorderLayout.SOUTH);
		this.add(jobbPanel);
	}
	
	public void SetData(Film f) {
		this.film = f;
		cim_jl.setText(f.getCim());
		ecim_jl.setText(f.getEredetiCim());
		mufaj_jl.setText(f.getMufaj());
		leiras_jl.setText(f.getLeiras());
		rendezo_jl.setText(f.getRendezo());
		ev_jl.setText(String.valueOf(f.getEv()));
		hossz_jl.setText(String.valueOf(f.getHossz()));
		korhatar_jl.setText(String.valueOf(f.getKorhatar()));
		
		BufferedImage myPicture = null;
		try {
			myPicture = ImageIO.read(new File(f.getBorito()));
		} catch (IOException e) {
			try {
				myPicture = ImageIO.read(new File(this.defaultimage));
			}
			catch (IOException ex) {
				ex.printStackTrace();
			}	
		}
		finally 
		{
			ImageIcon icon = new ImageIcon(myPicture); 
			kep.setIcon(icon);
		}
	}
	
	public JLabel getCimJl() {
		return cim_jl;
	}
	
	public JLabel getErdetiCimJl() {
		return ecim_jl;
	}
	
	public JLabel getLeirasJl() {
		return leiras_jl;
	}
	
	public JLabel getRendezoJl() {
		return rendezo_jl;
	}
	
	public JLabel getMufajJl() {
		return mufaj_jl;
	}
	
	public JLabel getEvJl() {
		return ev_jl;
	}
	
	public JLabel getKorhatarJl() {
		return korhatar_jl;
	}
	
	public JLabel getHosszJl() {
		return hossz_jl;
	}
	
	public void setDefaultImage(String defaultimage) {
		this.defaultimage = defaultimage;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getActionCommand()== "Vissza")
		{
			mf.getFilmPanel().Update();
			mf.getCardLayout().show(mf.getCards(), "MAIN");
		}
		else if(e.getActionCommand()== "Szerkesztes")
		{
			mf.getSzerkesztoPanel().setFilm(this.film);
			mf.getCardLayout().show(mf.getCards(), "SZERKESZTO");
		}
		else if(e.getActionCommand()== "Torles")
		{
			mf.getTar().remove(this.film);
			mf.getFilmPanel().Update();
			mf.getCardLayout().show(mf.getCards(), "MAIN");
		}
			
	}
}