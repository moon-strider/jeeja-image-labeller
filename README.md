# Jeeja Image Labeller

In order to make the labelling and dataset splitting process easier, I decided to revisit C# and WinForms to create an application that would aid me in my ML journey.

# Features

## Image Labelling

You may select an input folder from which images are to be loaded, then you select a .txt file featuring classes you need to label (one class per line) and finally set the output folder for saving labels in yolov3 format.

## TTV split

Similarly to image labelling, you select an input folder with a set of folders inside, each inside folder represents a class and sould contain images of said class. Then you select a .txt file containing the proportions of the split — 3 numbers (one per line). After the split, the output folder is going to contain the same folders as the input one, but inside them are going to be the TTV folders containing original images.
