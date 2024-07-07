import { mockData } from '../data';

const productsService = {
  getData() {
    return new Promise((resolve) => {
        resolve(mockData);
    });
  }
};

export default productsService;
