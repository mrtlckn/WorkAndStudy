import cv2 as cv
import imutils

img = cv.imread("Resources/kedi.png")
cv.imshow("Image", img)

#Vertically ve Horizontally işlemleri
verticallyimage  = cv.flip(img,0)
cv.imshow('Vertically Image',verticallyimage)
horizontallyimage  = cv.flip(img,1)
cv.imshow('Horizontally Image',horizontallyimage)

#Rotate İşlemleri için "imutils" kullandım
RotatedtoLeft90 = imutils.rotate(img, angle=90)
cv.imshow("RotatedtoLeft90", RotatedtoLeft90)
RotatedtoRight90 = imutils.rotate(img, angle=270)
cv.imshow("RotatedtoRight90", RotatedtoRight90)

#Resize işlemi
def rescaleFrace(frame,scale= 0.50):
    width = int(frame.shape[1] * scale)
    height = int(frame.shape[0] * scale)

    dimensions = (width,height)
    return cv.resize(frame,dimensions,interpolation=cv.INTER_AREA)

resized_image = rescaleFrace(img)


cv.imshow('Image', img)
cv.imshow('Resized Image half by aspect radio', resized_image)


cv.waitKey(0)

