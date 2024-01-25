TEMA EGC PDF-UL SUNT INTREBARILE DE LA LABORATORUL 11.






Intrebari EGC


1.Ce este un viewport?
Viewport este zona vizibilă a utilizatorului unei pagini web. Viewportul variază în funcție de dispozitiv și va fi mai mic pe un telefon mobil decât pe un ecran al computerului.

2.Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?
În contextul bibliotecii OpenGL, conceptul de "frames per second" (FPS) , dupa cum ii spune si numele se referă la măsurarea ratei de desenare a cadrului într-o aplicație grafică. FPS reprezintă numărul de cadre sau imagini complete generate și afișate pe ecran într-o secundă. Cu cât FPS-ul este mai mare, cu atât aplicația grafică va părea mai fluidă și mai reactivă pentru utilizatori. FPS-uri multe = performanta sporita !

3.Când este rulată metoda OnUpdateFrame()?
Această metodă este folosită pentru a actualiza logica jocului sau a aplicației în fiecare cadru (frame) și se rulează la fiecare iterație a ciclului de joc.
	Este urmata de metoda OnRenderFrame().

4.Ce este modul imediat de randare?

Modul imediat de randare este o tehnică  de randare utilizată în dezvoltarea grafică, mai ales în limbaje precum OpenGL și Direct3D. 
În modul imediat de randare, fiecare comandă de desenare (cum ar fi desenarea unui triunghi sau a altui obiect) este specificată direct prin apeluri de funcții grafice, precum glBegin(), glVertex(), și glEnd() în OpenGL. 

5.Care este ultima versiune de OpenGL care acceptă modul imediat?
OpenGL 3.0 , aceasta include versiuni precum OpenGL 3.1, 3.2, 3.3, 4.0 și ulterioare.

6.Când este rulată metoda OnRenderFrame()?

Acest ciclu de randare este responsabil de afișarea graficii pe ecran și se repetă în mod continuu pentru a crea iluzia mișcării și a interacțiunii în joc sau aplicație.Dupa cum am spus mai sus se foloseste dupa OnUpdateFrame()

7.De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?

Metoda OnResize() este responsabila pentru  asigurarea  aplicației grafice sau jocul se adaptează corect la schimbările dimensiunilor ferestrei sau viewport-ului, pentru a oferi o experiență utilizatorului coerentă și funcțională.

8.Ce reprezintă parametrii metodei 
CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?
Această metodă are mai mulți parametri, iar doi dintre cei mai importanți sunt următorii:
Field of View (FOV) și Aspect Ratio (Raportul de aspect)
