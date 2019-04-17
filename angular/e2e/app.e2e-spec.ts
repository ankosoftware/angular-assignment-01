import { AgEmailSenderTemplatePage } from './app.po';

describe('AgEmailSender App', function() {
  let page: AgEmailSenderTemplatePage;

  beforeEach(() => {
    page = new AgEmailSenderTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
