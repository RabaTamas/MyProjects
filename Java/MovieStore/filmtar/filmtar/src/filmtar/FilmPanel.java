package filmtar;

import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Collections;
import java.util.Comparator;
import java.util.LinkedList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.SwingConstants;

public class FilmPanel extends JPanel implements ActionListener {
    private JPanel filmpanel;
    private Tar<FilmGomb> gombok = new Tar<>();
    private Filmtar tar;
    private MainFrame mf;
        
	private void createAndAddButton(Film f) {
        FilmGomb b = new FilmGomb(f, mf);
		gombok.add(b);
		filmpanel.add(b);
	}
	
	private void createMainPanel() {
		this.setLayout(new BorderLayout());
		JPanel felsosav = new JPanel();
		JComboBox jcb = new JComboBox();
		jcb.addItem("cim");
		jcb.addItem("ev");
		jcb.addItem("mufaj");
		jcb.addActionListener(this);
		jcb.setActionCommand("rendezes");
		JTextField field = new JTextField(20);
		field.addActionListener(this);
		field.setActionCommand("kereses");
		felsosav.add(new JLabel("Kereses"));
		felsosav.add(field);
		felsosav.add(new JLabel("Rendezesi szempont"));
		felsosav.add(jcb);
		this.add(felsosav, BorderLayout.NORTH);
		filmpanel = new JPanel();
		JScrollPane jsp = new JScrollPane(filmpanel);
		//filmpanel.setLayout(new GridLayout(2,4,10,10));
		for(Film f: tar)
		{
			createAndAddButton(f);
			//createButton(f);
		}
		this.add(jsp);
		JPanel alsosav = new JPanel();
		JButton badd = new JButton("Hozzaad");
		badd.addActionListener(this);
		badd.setActionCommand("HOZZAAD");
		alsosav.add(badd);
		this.add(alsosav, BorderLayout.SOUTH);
	}
	
	public void Update()
	{
		filmpanel.removeAll();
		gombok.removeAll();
		for(Film f: tar)
		{
			FilmGomb g = new FilmGomb(f, mf);
			gombok.add(g);
			//createButton(f);
		}
		gombok.sort((x, y) -> x.GetFilm().getCim().compareTo(y.GetFilm().getCim()));
		for(FilmGomb g: gombok) {
			filmpanel.add(g);
		}
		
		filmpanel.repaint();
		filmpanel.revalidate();
	}
	
	private void Search(String keresett) {
		for(Film f: tar.Search(keresett)) {
			createAndAddButton(f);
		}
	}
	
	private void Sort(String feltetel) {
		if(feltetel == "cim")
			gombok.sort((FilmGomb x, FilmGomb y) -> x.GetFilm().getCim().compareTo(y.GetFilm().getCim()));
		else if(feltetel == "mufaj")
			gombok.sort((FilmGomb x, FilmGomb y) -> x.GetFilm().getMufaj().compareTo(y.GetFilm().getMufaj()));
		else if(feltetel == "ev")
			gombok.sort((FilmGomb x, FilmGomb y) -> ((Integer)(x.GetFilm().getEv())).compareTo(y.GetFilm().getEv()));
		for(FilmGomb g: gombok) {
			filmpanel.add(g);
		}
	}
		
	public void actionPerformed(ActionEvent event)
	{
		if(event.getActionCommand() == "kereses" || event.getActionCommand() == "rendezes")
		{
			filmpanel.removeAll();
			if(event.getActionCommand().equals("kereses"))
			{
				gombok.removeAll();
				Search(((JTextField)event.getSource()).getText());
			}
			else if(event.getActionCommand().equals("rendezes"))
			{
				Sort((String)((JComboBox) event.getSource()).getSelectedItem());
			}
			filmpanel.repaint();
			filmpanel.revalidate();
		}
		if(event.getActionCommand().equals("HOZZAAD"))
		{
			mf.getCardLayout().show(mf.getCards(), "HOZZAAD");
		}
		
	}
	
	public FilmPanel(Filmtar tar, MainFrame mf) {
		this.tar = tar;
		this.mf = mf;
		createMainPanel();
	}
	
	public Tar getGombok() {
		return gombok;
	}
}
