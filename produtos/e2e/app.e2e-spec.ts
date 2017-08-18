import { ProdutosPage } from './app.po';

describe('produtos App', () => {
  let page: ProdutosPage;

  beforeEach(() => {
    page = new ProdutosPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
