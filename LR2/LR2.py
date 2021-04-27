import colorsys
import math
import os
import sys
import random
import numpy as np
import matplotlib.pyplot as plt
import pyqtgraph.opengl as gl
from PyQt5 import uic
from PyQt5.QtWidgets import QApplication, QMainWindow, QTableWidgetItem
from PyQt5 import QtWidgets


def valmap(value, istart, istop, ostart, ostop):
    return ostart + (ostop - ostart) * ((value - istart) / (istop - istart))


class Window(QMainWindow):
    def __init__(self):
        super(Window, self).__init__()
        self.gui = uic.loadUi('LR2.ui')
        self.gui.show()

        self.gui.btn_generate_data.clicked.connect(self.generate_data)
        self.gui.btn_save_data.clicked.connect(self.save_data)
        self.gui.btn_load_data.clicked.connect(self.load_data)
        self.gui.btn_show_3d.clicked.connect(self.show_3d)

        self.gui.points_table.setColumnCount(3)
        self.gui.points_table.verticalHeader().setVisible(False)
        self.gui.points_table.setEditTriggers(QtWidgets.QAbstractItemView.NoEditTriggers)
        self.gui.points_table.setHorizontalHeaderItem(0, QtWidgets.QTableWidgetItem('X'))
        self.gui.points_table.setHorizontalHeaderItem(1, QtWidgets.QTableWidgetItem('Y'))
        self.gui.points_table.setHorizontalHeaderItem(2, QtWidgets.QTableWidgetItem('Z'))
        header = self.gui.points_table.horizontalHeader()
        header.setSectionResizeMode(0, QtWidgets.QHeaderView.Stretch)
        header.setSectionResizeMode(1, QtWidgets.QHeaderView.Stretch)
        header.setSectionResizeMode(2, QtWidgets.QHeaderView.Stretch)

        self.points = None

    def generate_data(self):
        print('Generating data...')
        points_num = self.gui.points_num.value()
        deviation_val = self.gui.deviation_val.value()
        self.points = []
        for i in range(points_num):
            self.points.append([0.5 * math.cos(4 * math.pi * (i / points_num)) +    # 0.7, 6
                                random.normalvariate(0, deviation_val),

                                0.5 * math.sin(4 * math.pi * (i / points_num)) +    # 0.5, 4
                                random.normalvariate(0, deviation_val),

                                -1 + 2 * i / points_num + random.normalvariate(0, deviation_val)])
        self.points = np.array(self.points)

        self.show_on_table()
        self.gui.btn_save_data.setEnabled(True)
        print('Data generated.')

    def save_data(self):
        print('Saving data...')
        np.savetxt(self.gui.data_file.text(), self.points, delimiter=' ')
        print('File', self.gui.data_file.text(), 'saved.')

    def load_data(self):
        if os.path.exists(self.gui.data_file.text()):
            print('Loading data...')
            self.points = np.loadtxt(self.gui.data_file.text(), delimiter=' ')
            self.show_on_table()
            print('File', self.gui.data_file.text(), 'loaded.')
        else:
            print('File', self.gui.data_file.text(), 'doesn\'t exist!')

    def show_on_table(self):
        self.gui.points_table.setRowCount(0)
        for point in self.points:
            row_position = self.gui.points_table.rowCount()
            self.gui.points_table.insertRow(row_position)
            self.gui.points_table.setItem(row_position, 0, QTableWidgetItem(str(point[0])))
            self.gui.points_table.setItem(row_position, 1, QTableWidgetItem(str(point[1])))
            self.gui.points_table.setItem(row_position, 2, QTableWidgetItem(str(point[2])))
        self.gui.btn_save_data.setEnabled(True)

    def show_3d(self):
        if self.points is not None and len(self.points) > 0:
            view = gl.GLViewWidget()
            view.show()

            # Walls
            gx = gl.GLGridItem()
            gy = gl.GLGridItem()
            gz = gl.GLGridItem()
            gx.rotate(90, 0, 1, 0)
            gy.rotate(90, 1, 0, 0)
            gx.translate(0, 0, 0)
            gy.translate(0, 0, 0)
            gz.translate(0, 0, 0)
            if self.gui.x_plane.isChecked():
                view.addItem(gx)  # X Plane
            if self.gui.y_plane.isChecked():
                view.addItem(gy)  # Y Plane
            if self.gui.z_plane.isChecked():
                view.addItem(gz)  # Z Plane
            view.addItem(gl.GLLinePlotItem())

            # Color rainbow
            z = np.array(np.array([item[2] for item in self.points]))
            cmap = plt.get_cmap('hsv')
            min_z = np.min(z)
            max_z = np.max(z)

            rgba_img = cmap(1.0 - (z - min_z) / (max_z - min_z))

            # Points cloud
            surface = gl.GLScatterPlotItem(pos=self.points, color=rgba_img)
            view.addItem(surface)
        else:
            print('No points! Please generate or load.')


if __name__ == '__main__':
    app = QApplication(sys.argv)
    app.setStyle('fusion')
    win = Window()
    sys.exit(app.exec_())
