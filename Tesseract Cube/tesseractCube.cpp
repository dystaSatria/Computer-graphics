
#include <GL/glut.h>
#include <math.h>

GLfloat vertices[][4] = {
    {-1, -1, -1, -1},
    {1, -1, -1, -1},
    {1, 1, -1, -1},
    {-1, 1, -1, -1},
    {-1, -1, 1, -1},
    {1, -1, 1, -1},
    {1, 1, 1, -1},
    {-1, 1, 1, -1},
    {-1, -1, -1, 1},
    {1, -1, -1, 1},
    {1, 1, -1, 1},
    {-1, 1, -1, 1},
    {-1, -1, 1, 1},
    {1, -1, 1, 1},
    {1, 1, 1, 1},
    {-1, 1, 1, 1},
};

int edges[][2] = {
    {0, 1}, {1, 2}, {2, 3}, {3, 0},
    {4, 5}, {5, 6}, {6, 7}, {7, 4},
    {0, 4}, {1, 5}, {2, 6}, {3, 7},
    {8, 9}, {9, 10}, {10, 11}, {11, 8},
    {12, 13}, {13, 14}, {14, 15}, {15, 12},
    {8, 12}, {9, 13}, {10, 14}, {11, 15},
    {0, 8}, {1, 9}, {2, 10}, {3, 11},
    {4, 12}, {5, 13}, {6, 14}, {7, 15},
};

float angleX = 0.0;
float angleY = 0.0;

void display() {
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glLoadIdentity();
    gluLookAt(5, 5, 5, 0, 0, 0, 0, 1, 0);

    glRotatef(angleX, 1.0, 0.0, 0.0);
    glRotatef(angleY, 0.0, 1.0, 0.0);

    glColor3f(1.0, 1.0, 1.0);
    glBegin(GL_LINES);
    for (int i = 0; i < 32; i++) {
        glVertex4fv(vertices[edges[i][0]]);
        glVertex4fv(vertices[edges[i][1]]);
    }
    glEnd();

    glutSwapBuffers();
}

void reshape(int w, int h) {
    glViewport(0, 0, w, h);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(60.0, (GLfloat)w / (GLfloat)h, 1.0, 30.0);
    glMatrixMode(GL_MODELVIEW);
}

void timer(int value) {
    angleX += 1.0;
    if (angleX > 360.0) {
        angleX -= 360.0;
    }
    angleY += 1.0;
    if (angleY > 360.0) {
        angleY -= 360.0;
    }
    glutPostRedisplay();
    glutTimerFunc(16, timer, 0);
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
    glutInitWindowSize(800, 600);
    glutCreateWindow("4D Tesseract Cube");

    glEnable(GL_DEPTH_TEST);

    glutDisplayFunc(display);
    glutReshapeFunc(reshape);
    glutTimerFunc(0, timer, 0);

    glutMainLoop();
    return 0;
}
