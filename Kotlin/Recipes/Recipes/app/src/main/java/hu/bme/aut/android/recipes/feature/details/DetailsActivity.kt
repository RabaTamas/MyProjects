package hu.bme.aut.android.recipes.feature.details

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.MenuItem
import hu.bme.aut.android.recipes.R
import hu.bme.aut.android.recipes.databinding.ActivityDetailsBinding

class DetailsActivity : AppCompatActivity() {

    private lateinit var binding: ActivityDetailsBinding
    private var food: String? = null

    companion object {
        private const val TAG = "DetailsActivity"
        const val EXTRA_FOOD_NAME = "extra.food_name"
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetailsBinding.inflate(layoutInflater)
        setContentView(binding.root)

        food = intent.getStringExtra(EXTRA_FOOD_NAME)

        supportActionBar?.title = getString(R.string.weather, food)
        supportActionBar?.setDisplayHomeAsUpEnabled(true)
    }

    override fun onResume() {
        super.onResume()
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        if (item.itemId == android.R.id.home) {
            finish()
            return true
        }
        return super.onOptionsItemSelected(item)
    }
}