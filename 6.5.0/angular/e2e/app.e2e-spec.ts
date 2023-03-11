import { fmsTemplatePage } from './app.po';

describe('fms App', function() {
  let page: fmsTemplatePage;

  beforeEach(() => {
    page = new fmsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
