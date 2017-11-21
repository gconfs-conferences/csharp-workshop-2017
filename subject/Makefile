FLAGS=-shell-escape

all: pdf view

pdf:
	pdflatex $(FLAGS) main_fr.tex

view:
	evince main_fr.pdf

clean:
	rm -rf *.aux *.log *.nav *.toc *.snm *.pdf *.out *.pyg _minted*
