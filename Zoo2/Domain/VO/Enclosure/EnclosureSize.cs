namespace Zoo2.Domain.VO.Enclosure;

public abstract class EnclosureSize;

public class UnrestrictedSize : EnclosureSize;

public class TwoDimensionalSize(int width, int length) : EnclosureSize
{
    private int _width = width;
    private int _length = length;
}

public class ThreeDimensionalSize(int width, int length, int height) : EnclosureSize
{
    private int _width = width;
    private int _length = length;
    private int _height = height;
}