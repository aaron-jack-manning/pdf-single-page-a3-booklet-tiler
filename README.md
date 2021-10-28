# PDF Single Page A3 Booklet Page Tiler

A simple application which takes single page A3 booklets as a .pdf and converts them into separated A4 pages.

## Use Case

This tool is designed for single page A3 booklets, in the following format (showing front on top and back on buttom, with page numbers indicating intended order).

![Layout](layout.png)

This is so it will fold into a booklet with 4 A4 sides.

## Usage

Source documents should be a series of A3 pages, alternating front and back page as shown in the above layout, so the provided .pdf has an even number of pages. A demo file is available for download.

To run the application, download a zip of the above by clicking the green `Code` button. Unzip the file, and open the application file entitled `PDF Single Page Booklet Tiling.exe`. Note, the executable depends on the other files in the application folder, and as such it is my recommendation to keep the application folder together.

Specify the source file as a full file path to the .pdf source (for example: `C:\Users\username\Desktop\Demo_File.pdf`) and the path to the destination file, including the name you wish to call it (for example: `C:\Users\username\Desktop\Demo_File_Tiling.pdf`).

Click `Tile PDF` and wait for a message to show up in the box below, to indicate success or failure.

## Requirements

You may be required to install the .net runtime, which can be found [here](https://dotnet.microsoft.com/download/dotnet/5.0/runtime). Select the option for desktop app.

## Links

This tool was built using the iText7 .Net Package which can be found [here](https://www.nuget.org/packages/itext7/).
