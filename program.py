import tkinter as tk
from tkinter import ttk
import tkinter.messagebox as tmb
from ttkthemes import ThemedStyle
 
class UI(ttk.Frame):
    def __init__(self, parent=None):
        super(UI,  self).__init__(parent)
        self.parent = parent
        style = ThemedStyle(parent)
        style.set_theme("arc")
        self.parent.geometry("480x520")
        self.init_ui()
 
    def init_ui(self):
        self.parent.title("New window")
        self.entrada = ttk.Entry(self, text="insert")
        self.entrada.grid(row=2, column=2) 
        boton = ttk.Button(self, text="puls", command=self.ver)
        boton.grid(row=2, column=3)
        self.pack()
 
    def ver(self):
        try:
            res = int(self.entrada.get())
            print(res)
        except ValueError:
            tmb.showwarning(title = "error", message = " error")
 
if __name__== '__main__':
    root = tk.Tk() 
    sug = tk.Label(root, text="example missing")
    sug.pack()
    app = UI(parent=root)
    app.mainloop()
