let primarytest = 'hsl(232, 27%, 72%)';
let primary = 'hsl(232, 55%, 72%)';

module.exports = {
  purge: {
    enabled: true,
    content: ["./src/*.html"],
  },
  theme: {
    gradients: theme => ({
      // Array definition (defaults to linear gradients).
      'topaz':      ['30deg', theme('colors.orange.500'), theme('colors.pink.400')],
      'topaz-dark': ['30deg', theme('colors.orange.700'), theme('colors.pink.600')],
      'emerald':    ['to right', theme('colors.green.400'), theme('colors.teal.500')],
      'fireopal':   ['to right', '#40E0D0', '#FF8C00', '#FF0080'],
      'relay':      ['to top left', '#3A1C71', '#D76D77', '#FFAF7B'],
      'buddy-flex': {
        type: 'repeating-linear',
        colors: ['45deg', primarytest, primarytest, 'hsl(232, 27%, 74%) 50px', 'hsl(232, 27%, 74%) 100px'],
      },

      // Object definition.
      'mono-circle': {
          type: 'radial',
          colors: ['circle', '#CCC', '#000']
      },
  }),
    extend: {
      colors: {
        primary: primary,
        primary_light: "#9cdbaa",
        primarytest: primarytest,
      },
    },
  },
  variants: {
    gradients: ["responsive", "hover", "focus"],
    colors: ["responsive", "hover", "focus"]
  },
  plugins: [require("tailwindcss-plugins/gradients")],
};
