import axiosInstance from '../axios';

const productsService = {
  async getData() {
    try {
      const response = await axiosInstance.get('/Produto');
      return response.data;
    } catch (error) {
      console.error("Erro na requisição GET de dados", error);
      throw error;
    }
  },

  async updateData(product) {
    try {
      const response = await axiosInstance.put(`/Produto/${product.codigo}`, product);
      return response.data;
    } catch (error) {
      console.error("Erro na requisição PUT de atualização", error);
      throw error;
    }
  }
};

export default productsService;
