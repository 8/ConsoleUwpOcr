# UWP OCR Console Application

## Author
Written by martin kramer &lt;martin.kramer@lostindetails.com&gt;

## Description

A very simple console application that demonstrates how the UWPDesktop nuget package can be used to access the UWP OCR engine to recognize characters from an image.

As it depends on the OCR Engine contained within UWP Applications, even though it's a windows console app, it can only work on a version of windows that supports UWP, like Win10.

## Example usage
```
ocr.exe ..\..\..\ConsoleUwpOcr.Test\TestData\testimage.png
Welcome to Thunderbird Donate to Thunderbird Thunderbird IS the leading open source, cross- platform email and calendaring client, free for business and personal use. We want it to stay secure and become even better. If you like Thunderbird, please consider a donation! By donating, you Will help us to continue delivering an ad-free top-notch email client. Make a donation » Other ways to contribute to Thunderbird Now IS a great time for you to get involved: writing code, testing, support, localization and more. Join a global community! Share your skills and Pick up a few new ones along the way. Volunteer as much as you like. Or as little. It's totally up to you. Learn more » Why we need donations You might already know that Thunderbird improvements are no longer paid for by Mozilla. Fortunately there IS an active community keeping it running and developing it further. But to survive long term, the project needs funding. Thunderbird IS currently transitioning to an independent organization. Being independent, we can shape our own fate, but there IS significant infrastructure that must be majntajned to deliver the application to our tens of millions of users. For Thunderbird to survive and continue to evolve, we need your support and ask for your donation today. All the money donated Will go directly to funding Thunderbird development and infrastructure.
```
