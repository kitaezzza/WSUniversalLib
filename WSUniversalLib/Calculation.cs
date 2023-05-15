namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// метод расчитывает целое кол-во сырья, необходимое для производства определенного кол-ва продукции, учитывая возможный брак материалов
        /// </summary>
        /// <param name="productType"> Продукция</param>
        /// <param name="materialType"> Материал</param>
        /// <param name="count"> Кол-во </param>
        /// <param name="width"> Ширина</param>
        /// <param name="length"> Длина</param>
        /// <returns> Целое кол-во сырья, (-1) если не верные параметры</returns>


        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (count <= 0 || width <= 0 || length <= 0)
                return -1;
            try {
                float coefproductType = GetProductType(productType);
                float coefMaterialType = GetMaterialType(materialType);
                float notDefect = GetMaterialNotDefect(coefproductType, count, width, length);
                float defect = GetDefect(notDefect, coefMaterialType);
                return RoundUp(notDefect + defect); // заглушка
            }
            catch (Exception ex)
                {
                   return -1;
                }
            }

        private int RoundUp(float itog)
        {
         return (int) Math.Ceiling(itog);
        }

        private float GetDefect(float notDefect, float coefMaterialType)
        {
         return notDefect* coefMaterialType;
        }

        private float GetMaterialNotDefect(float coefproductType, int count, float width, float length)
        {
          return (float)Math.Ceiling(coefproductType * width * length * count);
        }

       

        private float GetMaterialType(int materialType)
        {
            switch (materialType)
            {
             case 1: return 0.003f;
             case 2: return 0.0012f;
             default: throw new Exception();
            }
        }
        private float GetProductType(int productType)
            {
               switch(productType)
                {
                case 1: return 1.1f;
                case 2: return 2.5f;
                case 3: return 8.43f;
                default: throw new Exception();
               }
            }
    }
}