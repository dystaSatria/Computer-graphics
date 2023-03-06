#include <GL/glut.h>
#include<gl\freeglut.h>
#include<windows.h>
#include<math.h>

/* 
void segitiga()
{
glClear(GL_COLOR_BUFFER_BIT);
//Gambar segitiga sama sisi berwarna biru
glColor3f(1,0,1);
glBegin(GL_TRIANGLES);
glVertex2f(0.5,0.1);
glVertex2f(0.8,0.1);
glVertex2f(0.5,0.3);
glEnd();
glFlush();
}


void titik(){
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(1,0,1);
	glPointSize(10);
	glBegin(GL_POINTS);
	glVertex2f(0.9,0.9);
	glEnd();
	glFlush();
	
}


void display (void)
{
glClear(GL_COLOR_BUFFER_BIT);
titik();
segitiga();
glutSwapBuffers();



}


int main(int argc, char **argv)
{
glutInit(&argc, argv);
glutInitDisplayMode(GLUT_DEPTH | GLUT_SINGLE | GLUT_RGBA);
glutCreateWindow("Segi Tiga");
glutDisplayFunc(display);
glutMainLoop();


}

*/

void display(){
		
		glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
		glClear(GL_COLOR_BUFFER_BIT);
		glLoadIdentity();
		
		glBegin(GL_TRIANGLES);
			glColor3f(1.0f, 0.0f ,1.0f);
			glVertex2f(0.5f, 0.1f);
			glVertex2f(0.8f, 0.1f);
			glVertex2f(0.5f, 0.3f);
		glEnd();
		
		glBegin(GL_POINTS);
			glPointSize(8);
			glColor3f(1.0f,0.0f,1.0f);
			glVertex2f(0.5f,0.5f);
		glEnd();
		
		
		glFlush();
		

}

void move(){
	
}

int main(int argc, char** argv)
{
glutInit(&argc, argv);
//glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE);
glutCreateWindow("Odev");	
glutInitWindowSize(420,400);
glutDisplayFunc(display);
glutMainLoop();
return 0;


}
